// 滚动条
var scrolltotop = {
    setting: {startline:20, scrollto:0, scrollduration:300, fadeduration:[500, 100]} ,
    controlHTML: '<img src="http://www.paidai.com/images/new/top.jpg" style="width:53px; height:49px" />' ,
    controlattrs: {offsetx:0, offsety : 30} ,
    anchorkeyword: '#top' ,
    state: {isvisible:false, shouldvisible:false},
    scrollup:function() {
        if (!this.cssfixedsupport) this.$control.css({opacity:0});
        var dest = isNaN(this.setting.scrollto)? this.setting.scrollto : parseInt(this.setting.scrollto);
        if (typeof dest=="string" && jQuery('#'+dest).length==1) {
            dest=jQuery('#'+dest).offset().top;
        } else {
            dest=0;
        }
        this.$body.animate({scrollTop: dest}, this.setting.scrollduration);
    },

    keepfixed:function() {
        var $window = jQuery(window);
        var controlx = ($window.scrollLeft() + $window.width())/2;
        var controly = $window.scrollTop() + $window.height() - this.$control.height() - this.controlattrs.offsety;
        this.$control.css({left:controlx+'px', top:controly+'px'});
    },

    togglecontrol : function() {
        var scrolltop = jQuery(window).scrollTop();
        if (!this.cssfixedsupport) this.keepfixed();
        this.state.shouldvisible=(scrolltop>=this.setting.startline)? true : false;
        if (this.state.shouldvisible && !this.state.isvisible) {
            this.$control.stop().animate({opacity : 1}, this.setting.fadeduration[0]);
            this.state.isvisible = true;
        } else if (this.state.shouldvisible == false && this.state.isvisible) {
            this.$control.stop().animate({opacity : 0}, this.setting.fadeduration[1]);
            this.state.isvisible = false;
        }
    },

    init : function() {
        jQuery(document).ready(function($) {
            var mainobj = scrolltotop;
            var iebrws=document.all;
            mainobj.cssfixedsupport =! iebrws || iebrws && document.compatMode=="CSS1Compat" && window.XMLHttpRequest;
            mainobj.$body=(window.opera)? (document.compatMode=="CSS1Compat"? $('html') : $('body')) : $('html,body');
            mainobj.$control=$('<div id="topcontrol">'+mainobj.controlHTML+'</div>')
                .css({position:mainobj.cssfixedsupport? 'fixed' : 'absolute', bottom:mainobj.controlattrs.offsety, left:"50%","marginLeft":"491px" ,opacity:0, cursor:'pointer'})
                .attr({title:'Scroll Back to Top'})
                .click(function(){mainobj.scrollup(); return false;})
                .appendTo('body');
            if (document.all && !window.XMLHttpRequest && mainobj.$control.text()!='') {
                mainobj.$control.css({width:mainobj.$control.width()});
            }
            mainobj.togglecontrol();
            $('a[href="' + mainobj.anchorkeyword +'"]').click(function(){
                mainobj.scrollup();
                return false;
            });
            $(window).bind('scroll resize', function(e) {
                mainobj.togglecontrol();
            });
        });
    }
};

/**********************************************/
//弹出注册框
function show_reg_box() {
    var box1 = $('#login_box_bg');
    if(box1.length>0) {
        box1.hide();
    }
    var box = $('#reg_box_bg');
    if(box.length<1) {
        return;
    }
    var $win = $(window);
    var reg_x = ($win.width()-box.width())/2;
    var reg_y = ($win.height() -box.height())/2 + $win.scrollTop();
    if(reg_x<0) reg_x = 0;
    if(reg_y<0) reg_y = 0;
    box.css({top:reg_y,left:reg_x}).show();
    $("#loginClose_btn").bind('click', function(){$("#reg_box_bg").css({top:0,left:0}).hide();});
};

// 弹层登录框
function ajax_login() {
    var box1 = $('#reg_box_bg');
    if(box1.length>0) {
        box1.hide();
    }
    var box = $('#login_box_bg');
    if(box.length<1) {
        return;
    }
    var $win = $(window);
    var login_x = ($win.width()-box.width())/2;
    var login_y = ($win.height() -box.height())/2 + $win.scrollTop();
    if(login_x<0) login_x = 0;
    if(login_y<0) login_y = 0;
    box.css({top:login_y,left:login_x}).show();
    $("#loginClose_btn").bind('click', function(){$("#login_box_bg").css({top:0,left:0}).hide();});
}
function ajax_login_submit() {
    var account = $('#ajax_account').val(),
        passwd = $('#ajax_passwd').val(),
        tips = $('#ajax_login_tips');
    if(!account || !passwd) {
        tips.html('请输入帐号、密码').addClass('error').show();
        return false;
    }
    $.ajax({
        url: _domain_default + 'user/api.php',
        data: {act: 'login', account: account, passwd: passwd},
        dataType: 'jsonp'
    });
    return false;
};

// jsonP登录
function jsonP_login(data) {
    if(typeof(data)!='object') return false;
    var tips = $('#ajax_login_tips');
    // 登录失败
    if(data['status']==501) {
        tips.html('密码错误，请重新输入！').addClass('error').show();
    }
    // 登录成功
    if(data['status']==201) {
        if(data['code']==1) {
            if( data['redirect']) {
                window.location.href = data['redirect'];
            } else {
                window.location.reload();
            }
        } else {
            tips.html('用户名或密码错误！').addClass('error').show();
        }
    }
    return false;
}
/**********************************************/
// jsonP 关注
function add_follow(uid, obj) {
    $.getJSON(_domain_my + 'api.php?jsoncallback=?', {act: 'follow', uid: uid}, function(data){
        if(data['status']==201) {
            var box = $(obj).parent().parent();
            box.find(".attention").css("display","none");
            box.find(".close_attention a").css("display","inline-block");
            box.find(".close_attention").css("display","inline-block");
        } else {
            alert(data['msg']);
        }
    });
};

// jsonP 取消关注
function remove_follow(uid, obj) {
    $.getJSON(_domain_my + 'api.php?jsoncallback=?', {act: 'removefollow', uid: uid}, function(data){
        if(data['status']==201) {
            var box = $(obj).parent().parent();
            box.find(".close_attention a").css("display","none");
            box.find(".close_attention").css("display","none");
            box.find(".attention").css("display","inline-block");
        } else {
            alert(data['msg']);
        }
    });
};

/**
 * 获取cookie
 *
 * @author chenchuanyao@paidai.com
 * @since 2011-12-01
 *
 */
function getCookie(name) {
    var arg=name+"=";
    var alen=arg.length;
    var clen=document.cookie.length;
    var i=0;
    while(i < clen) {
        var j=i+alen;
        if(document.cookie.substring(i,j)==arg)
      return getCookieVal(j);
    i=document.cookie.indexOf(" ",i)+1;
    if(i==0) break;
  }
  return null;
};

/**
 * 获取cookie
 *
 * @author chenchuanyao@paidai.com
 * @since 2011-12-01
 *
 */
function getCookieVal(offset) {
    var endstr=document.cookie.indexOf(";",offset);
    if(endstr==-1) {
        endstr=document.cookie.length;
    }
    return unescape(document.cookie.substring(offset,endstr));
};

/**
 * 设置cookie
 *
 * @author chenchuanyao@paidai.com
 * @since 2011-12-01
 *
 * setCookie(name, value, expires, path, domain, secure);
 *
 */
function setCookie(name,value) {
    var argv=setCookie.arguments;

    var argc=setCookie.arguments.length;

    var today = new Date();
    var expireDay = new Date();
    var msPerMonth = 24*60*60*365;
    expireDay.setTime( today.getTime() + msPerMonth );
    var expires=(2 < argc) ? argv[2] : expireDay;

    var path=(3 < argc) ? argv[3] : null;

    var domain=(4 < argc) ? argv[4] : null;

    var secure=(5 < argc) ? argv[5] : false;

    document.cookie=name+"="+escape(value)+((expires==null)?"":("; expires="+expires.toGMTString()))+((path==null)?"":("; path="+path))+((domain==null)?"":("; domain="+domain))+((secure==true)?"; secure":"");
};

// 新动态提醒[执行次数限制]
var limitTimes = 3;
var runHandler = null;
function getUnreadInfo() {
    if (runHandler == null) {
        // 3分钟执行一次, 共执行limitTimes次
        flush_noread_total();
        runHandler = setInterval(flush_noread_total, 1000 * 180);
    }
};

function flush_noread_total() {

    if (limitTimes < 1) {
        clearInterval(runHandler);
        return false;
    }

    limitTimes -= 1;

    var tips_dialog = $('#tips_noread_dialog'),
        tips_pm = $('#tips_noread_pm'),
        tips_syspm = $('#tips_noread_syspm'),
        tips_newfans = $('#tips_noread_newfans'),
        tips_all_dynamic = $('#tips_index_all_dynamic'),
        tips_only_news = $('#tips_index_only_news'),
        tips_only_topic = $('#tips_index_only_topic'),
        tips_at = $('#tips_at'),
        tips_support = $('#tips_support');

    // 判断当前页面是否有需要读取用户动态记录业务
    if(tips_dialog.length > 0 || tips_pm.length > 0 || tips_all_dynamic.length > 0 || 
            tips_only_topic.length > 0 || tips_only_news.length > 0 || tips_newfans.length > 0) {

        $.getJSON(_domain_my + 'serv.php?act=noread_total&jsoncallback=?',  function(data) {
            if('object' == typeof(data) && data['error'] == 201) {
                var content = data['content'];
                var all_dynamic = content['all_dynamic'],
                only_topic = content['only_topic'],
                newpm = content['newpm'],
                syspm = content['syspm'],
                new_fans = content['new_fans'],
                bbs_reply = content['bbs_reply'],
                news_reply = content['only_news'];
                var at = content['at'];
                var support = content['support']
                if(tips_at.length>0) {
                    if(at>0) {
                        if(at>9) {
                            tips_at.css('font-size','8px');
                        }
                        at = at > 99 ? '99+':at;
                        tips_at.text(at);
                        tips_at.show();
                    } else {
                        tips_at.text('0');
                        tips_at.hide();
                    }
                }
                if(tips_support.length > 0) {
                    if(support > 0) {
                        if(at>9) {
                            tips_support.css('font-size','8px');
                        }
                        support = support > 99 ? '99+' : support;
                        tips_support.text(support);
                        tips_support.show();
                    } else {
                        tips_support.text('0');
                        tips_support.hide();
                    }
                }
                // 所有动态
                if(tips_all_dynamic.length>0) {
                    if(all_dynamic>0) {
                        if(at>9) {
                            tips_all_dynamic.css('font-size','8px');
                        }
                        all_dynamic = all_dynamic > 99 ? '99+' : all_dynamic;
                        tips_all_dynamic.text(all_dynamic);
                        tips_all_dynamic.show();
                    } else {
                        tips_all_dynamic.text('0');
                        tips_all_dynamic.hide();
                    }
                }

                // 这里只看主题， 只出现在首页
                if(tips_only_topic.length > 0) {
                    if(only_topic>0) {
                        tips_only_topic.html('('+only_topic+')').fadeIn();
                    } else {
                        tips_only_topic.html('').fadeOut();
                    }
                }

                // 这里 只看资讯， 只出现在首页
                if(tips_only_news.length > 0) {
                    if(news_reply > 0) {
                        tips_only_news.html('('+news_reply+')').fadeIn();
                    } else {
                        tips_only_news.html('').fadeOut();
                    }
                }

                // 新粉丝提醒
                if(tips_newfans.length > 0 && new_fans > 0) {
                    var total = 0;
                    if(tips_newfans.html() == '') {
                        total = new_fans;
                    } else {
                        total = parseInt(tips_newfans.html().substr(1)) + parseInt(new_fans);
                    }
                    tips_newfans.html('+' + total).fadeIn();
                    tips_newfans.parent().show();
                }

                // 回复我的
                if(tips_dialog.length > 0) {
                    if(bbs_reply > 0) {
                        if(at>9) {
                            tips_dialog.css('font-size','8px');
                        }
                        if(bbs_reply > 99) bbs_reply = '99+';
                        tips_dialog.text(bbs_reply);
                        tips_dialog.show();
                    } else {
                        tips_dialog.text('0');
                        tips_dialog.hide();
                    }
                }

                // 私信
                if(tips_pm.length>0) {
                    if(newpm>0) {
                        if(at>9) {
                            newpm.css('font-size','8px');
                        }
                        newpm = newpm>99 ? '99+' : newpm;
                        tips_pm.text(newpm);
                        tips_pm.show();
                    } else {
                        tips_pm.text('0');
                        tips_pm.hide();
                    }
                }

                // 系统通知
                if(tips_syspm.length > 0) {
                    if(syspm > 0) {
                        syspm = syspm > 99 ? '99+' : syspm;
                        tips_syspm.text(''+syspm+'');
                        tips_syspm.show();
                    } else {
                        tips_syspm.text('0');
                        tips_syspm.hide();
                    }
                }
				//提示
				//$('#tips_notice').parent().show();
            }
        }, 'json');
    }
};



var search_keyword = '',
        search_run = 0;
function searchLite(keyword) {
    if(search_run == 1) {
        return;
    }
    $.getJSON('http://www.paidai.com/search/index.php?act=js_html&jsoncallback=?', {s:keyword}, function(data){
        search_run = 0;
        if(data['error'] == 0) {
            var searchBox_result = $('#searchBox_result');
            if(searchBox_result.length < 1) {
                searchBox_result = $('<div id="searchBox_result"><ul class="searchBox_result"></ul></div>');
                $(searchBox_result).insertAfter($('#search'));
            }
            if(data['content']!='') {
                searchBox_result.html(data['content']);
                $(searchBox_result).show();
                // $('#searchBox_result a.search_result').highlight(keyword, {wrapper:"strong", needUnhighlight:true, hColor:''})
            }
        }
    }, 'json');
}

$(function() {

    var placeholderIsSupport = true;
    var changeBannerWord = false;
    var oldKeywords = '';
    if ( !( 'placeholder' in document.createElement('input') ) )
    {
        placeholderIsSupport = false;
    }
    var search_box = $('#search_box');
    $('#searchForm').submit(function(){

        // 支持placeholder,输入框为空
        if(placeholderIsSupport && search_box.val() == '') {
            $('#searchForm input[name="pos"]').removeAttr('disabled');
            search_box.val(search_box.attr('placeholder'));
        } else if(!placeholderIsSupport && changeBannerWord == false) {
            $('#searchForm input[name="pos"]').removeAttr('disabled');
        }

        if (search_box.val() == '') {
            return false;
        };

        return true;
    });
    //搜索 force
    search_box
    .bind('focus', function(){
        var obj = $(this);
        obj.css('color', '#000');
        $("#search_btn").css("background-position","center -30px");
        var placeholder = obj.attr('placeholder');
        if(!placeholderIsSupport && placeholder == obj.val() && changeBannerWord==false){
            obj.val('');
        }
        if(obj.val() == '搜索你感兴趣的内容或人…') {
            obj.val('');
        }
    })
    .bind('blur', function(){
        var obj = $(this);
        obj.css("background-position","center 9px");
        if(placeholderIsSupport==false && obj.val() == '') {
            obj.css('color', '#E6E6E6');
            var placeholder = obj.attr('placeholder');
            var keyword = placeholder ? placeholder : '搜索你感兴趣的内容或人…';
            obj.val(keyword);
            if(placeholder) {
                changeBannerWord = false;
            }
        }
    })
    .keyup(function(){
        
    });

    var searchTimer = 0;
    var checkSearchDo = function(){
        var obj = search_box;
        var keyword = obj.val();
        var placeholder = obj.attr('placeholder');
        if (oldKeywords == '') {
            oldKeywords = placeholder ? placeholder : keyword;
            searchTimer = setTimeout(function(){
                checkSearchDo();
            }, 500);
            return;
        };
        
        if(placeholder && placeholder != obj.val()) {
            changeBannerWord = true;
        }
        search_keyword = keyword;
        if(oldKeywords != search_keyword && keyword != '搜索你感兴趣的内容或人…' && keyword != '' && keyword.length >= 2) {
            oldKeywords = search_keyword;
            searchLite(keyword);
        }
        searchTimer = setTimeout(function(){
            checkSearchDo();
        }, 500);
    };
    
    checkSearchDo();

    $.getJSON(_domain_default + 'search/index.php?act=bannerword&jsoncallback=?', function(data){
        if(data['error'] == 0) {
            var word = data['content'];
            var input = $('#search_box');
            input.attr('placeholder', word);
            if (placeholderIsSupport)
            {
                input.val('');
            } else {
                input.val(word);
            }
        }
    });

    $(document).click(function(){
        if($('#search_box').is(":visible")) {
            var obj = $(this).parents('#searchBox_result');
            if(obj.length > 0 || $(this) == $('#search_box')) {
            } else {
                $('#searchBox_result').fadeOut();
                $('#searchBox_result ul').html('');
            }
        }
    });

});


/**
 * 延迟加载百度-新浪微博-腾讯微博插件
 */
function _lazyLoadPlugin() {
//    var bdshare_js = document.createElement('script'),
//        bdshell_js = document.createElement('script'),
//        evalScript = document.createElement('script'),
//        bdshare_box = document.getElementById('_bdshare_box_');
//
//    bdshare_js.id = 'bdshare_js';
//    bdshare_js.type = 'text/javascript';
//    bdshare_js.setAttribute('data','type=tools');
//
//    bdshell_js.id = 'bdshell_js';
//    bdshell_js.type = 'text/javascript';
//
//    evalScript.type = 'text/javascript';
//    evalScript.text = 'document.getElementById("bdshell_js").src = "http://bdimg.share.baidu.com/static/js/shell_v2.js?t=" + new Date().getHours();';
//
//    bdshare_box.appendChild(bdshare_js);
//    bdshare_box.appendChild(bdshell_js);
//    bdshare_box.appendChild(evalScript);

//    $('#_bdshare_box_').prepend(
//        '<!-- Baidu Button BEGIN -->' +
//        '<div id="bdshare" class="bdshare_t bds_tools get-codes-bdshare" data="{\'url\':\'http://www.paidai.com\',\'text\':\'播种分享，收获成长。派代，电商人交流成长的家园！\'}">' +
//            '<a class="bds_qzone" style="margin-left: 0px;"></a>' +
//            '<a class="bds_tsina" style="margin-left: 0px;"></a>' +
//            '<a class="bds_tqq" style="margin-left: 0px;"></a>' +
//            '<a class="bds_renren" style="margin-left: 0px;"></a>' +
//            '<a class="bds_t163" style="margin-left: 0px;"></a>' +
//            '<span class="bds_more"></span>' +
//            '<a class="shareCount" title="累计分享0次">0</a>' +
//        '</div>'
//    );
//    $('#_bdshare_box_').prepend(
//        '<!-- Baidu Button BEGIN -->' +
//        '<div class="bdsharebuttonbox" >'+
//              '<a href="#" class="bds_more" data-cmd="more"></a>'+
//              '<a href="#" class="bds_weixin" data-cmd="weixin" title="分享到微信"></a>'+
//              '<a href="#" class="bds_qzone" data-cmd="qzone" title="分享到QQ空间"></a>'+
//              '<a href="#" class="bds_tsina" data-cmd="tsina" title="分享到新浪微博"></a>'+
//              '<a href="#" class="bds_tqq" data-cmd="tqq" title="分享到腾讯微博"></a>'+
//              '<a href="#" class="bds_tieba" data-cmd="tieba" title="分享到百度贴吧"></a>'+
//          '<a class="shareCount" href="#" title="累计分享0次">0</a>'+
//          '</div>'
//    );
    $('#_sinawb_box_').html('<iframe width="120" height="24" frameborder="0" allowtransparency="true" marginwidth="0" marginheight="0" scrolling="no" border="0" src="http://widget.weibo.com/relationship/followbutton.php?language=zh_cn&width=136&height=24&uid=1770735827&style=2&btn=light&dpc=1"></iframe>');
    $('#_qqzone_box_').html('<iframe width="120" height="24" src="http://open.qzone.qq.com/like?url=http%3A%2F%2Fuser.qzone.qq.com%2F611962003&type=button_num&width=400&height=30&style=2" allowtransparency="true" scrolling="no" border="0" frameborder="0"></iframe>');
};

/**
 * 监控部分主题链接
 */
function checkAdTopicLink(){

    if(typeof _dd_topic_ids === 'undefined') {
        return;
    }
    // if(_dd_topic_ids.length < 1) return;

    var bbs_detail_url = _domain_bbs + 'topic/';
    var str = '';
    var rArr = [];
    var reg = /^([\d]+)[^\d]+/;
    var href = '';
    
    $('a').each(function(i, item){
        href = item.href;
        if(href.indexOf(bbs_detail_url)==0) {
            var s = href.replace(bbs_detail_url, '').replace(reg, '$1');
            if(jQuery.inArray(s, rArr) == -1 && jQuery.inArray(s, _dd_topic_ids) > -1) {
                rArr.push(s);
            }
        }
    });
    
    if(rArr.length<=0) return;
    $.getJSON(_domain_bbs + 'ddtopic.php', {act:'pushinfo', ids: rArr}, function(data){
        // alert(data['content']);
    });

}

$(document).ready(function() {
    // remove dashed box style
    if(!-[1,]) {
        for(var link_idx = 0; link_idx < document.links.length; link_idx++) {
            document.links[link_idx].onfocus = function(){this.blur();};
        }
    }
    
    // 初始化[返回顶部]图片按钮
    scrolltotop.init();
    
    /******************意见反馈弹层****************************/
    $('.feedback a').click(function(){$('.fbox_shadow').fadeIn(300); $(this).parent().fadeOut(100);});
    $('.suggestion_close_btn').click(function(e){$('.fbox_shadow').fadeOut(100); $('.feedback').fadeIn(300);e.preventDefault();});
    //联系方式
    var _contact = $('#contact_word').val();
    var _contact_name = $('#contact_name').val();
    $('.submit_btn').css('margin','10px 12px 0 0');
    $('.fbox_shadow .contact_word').click(function(){$(this).attr("value","");});
    $('.submit_btn').click(function(){ 
        var _val = encodeURIComponent($('.fbox textarea').val());
        var section = $('#section').attr('checked') == 'checked' ? 'bug':'improve';    
        //提交联系方式
        if(typeof(_contact_name) != "undefined"){
            if(_contact_name != ""){
                _contact_name = $('#contact_name').val();
                if(_contact_name == "请留下您的姓名(选填)"){
                    _contact_name = "游客";
                }
            }else{
                _contact_name = "游客";
            }
        }else{
            _contact_name = "游客";
        }
        if(typeof(_contact) != "undefined"){
            if(_contact != ""){
                _contact = $('#contact_word').val();
                if(_contact == "请留下您的联系方式(选填)"){
                    _contact = "游客";
                }
            }else{
                _contact = "游客";
            }
        }else{
            _contact = "游客";
        }
        $.getJSON('http://www.paidai.com/admin/pms/index.php?act=subbug&content='+_val+'&contact='+_contact+'&contact_name='+_contact_name+'&type=bug&uid='+_user_id+'&uname='+_user_name+'&format=json&jsoncallback=?',function(data){
//            if(data.error == 0) {
//                    $.getJSON("http://www.paidai.com/my/pm.php?act=save&jsoncallback=?", {username: _user_name, ctn : 'pms', type : 'pms'});
//            }
        });    
        $('.fbox textarea').val('');
        $('.fbox_shadow').hide();
        $('.fbox textarea').val('');
        $('.feedback').show();
    });
    
    /******************新版搜索框处理****************************/
    // 搜索框 focus
    $("#search_input").focus(function() {
        if($(this).val() =='搜索你感兴趣的干货…') $(this).val("");
        $(this).css("color","#000");
    });

    // 搜索框 blur
    $("#search_input").blur(function() {
        $(this).css("color","#a0a0a0");
        if($(this).val()=='') $(this).val("搜索你感兴趣的干货…");
    });

    // 延迟5秒执行[获取个人最新动态]
    setTimeout(getUnreadInfo, 5 * 1000);
    
    // 延迟5秒执行[公共页面底部的百度分享-微博外站插件]
    setTimeout(_lazyLoadPlugin, 6 * 1000);
    
    checkAdTopicLink();
    
});

