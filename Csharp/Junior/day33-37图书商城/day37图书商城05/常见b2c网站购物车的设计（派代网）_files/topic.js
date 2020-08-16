//右侧热门主题列表背景图片开始
$(function() {
    // 延迟加载图片
    delayLoadImg();

    //监听滚动条事件
    keylistionscroll();

    //关闭浏览记录的按钮
    $('.pview_bar .p_close_btn').click(function() {
        $('.pview_bar').fadeOut(1000);
    });

    //控制当前页大于1的页面不显示剩余多少条回复
    if ($('#cur_page_num').val() > 1) {
        $('.reply_more_box').hide();
        //显示的底部边框
        var rv = $('#cur_replylist_maxid').val();
        $('#pid_' + rv).css({'border-bottom': '1px solid #E6E6E6'});
    } else {
        $('.reply_more_box').show();
        $('#pid_' + rv).css({'border': 'none'});
    }
    /*
     if($('#reply_list dl').length>0) {
     max_repid = $('#cur_replylist_maxid').val();
     //当前页大于1 并且不存在更多按钮（因为异步加载了旧的和新回复 ）
     if($('#cur_page_num').val()>1 && $('.reply_more_box').css('display')=='none') {
     k_r = setInterval('check_isreload()',500);
     }
     }
     */

    //判断是否跳转到上次浏览位置
    if ($('#_visited_difence').val() == 'k') {
        var url = $('#_floor_url').val(),
                tid = $('#reply_iframe_topicid').val(),
                defCnt = $('#_defalut_reply_cnt').val(),
                startid = $('#_defalut_floors').val(),
                catid = $('#_cat_id').val();

        //如果是第一页 隐藏回到浏览的按钮
        if ($('#cur_page_num').val() == 1) {
            $('.pview_bar').hide();
        }

        //预先加载1次
        if ($('#_one_reload').val() == 'one') {
            if ($('.reply_more_box').css('display') == 'block') {
                $('.reply_more_box').hide();
            }
            geto_all_rep(tid, startid, defCnt);
            setTimeout('conVisitY()', 2000);
        }

        //预先加载2次
        if ($('#_two_reload').val() == 'two') {
            if ($('.reply_more_box').css('display') == 'block') {
                $('.reply_more_box').hide();
            }
            geto_all_rep(tid, startid, defCnt * 2);
            setTimeout('conVisitY()', 2000);
        }

        //不需要预先加载直接跳转
        if ($('#_one_reload').val() == '' && $('#_two_reload').val() == '') {
            conVisitY();
        }
    }

    var href = window.location.href;
    if (href.split("#")[1] == 'nr') {
        order_newest(topic_id);
    }else if(href.split("#")[1] == 'lz'){
        order_newestlz(topic_id);
    }

    // 用户自己删除帖子
    $("#self_del").click(function() {
        var r = confirm("您确定要删除该主题？");
        if (!r) {
            return false;
        }
    });

//    var href = window.location.href;
//    if (href.split("#")[1] == 'nr') {
//        order_newest(topic_id);
//    }

    $("#topic_reply_a").click(function() {
        if ($("#reply_content").is(":visible")) {
            $("#reply_content").fadeOut();
            $("div.reply_more_box").fadeOut();
            $("#reply_iframe").focus();
            $(this).text("展开回复");
        } else {
            $("#reply_content").fadeIn();
            $("div.reply_more_box").fadeIn();
            $("#reply_iframe").blur();
            $(this).text("快捷回复");
        }
    });

    // 定位异步中的回复
    if (location.href.split('sign=')[1] && location.href.split('sign=')[1].split('&rid=')[0] == 'ajaxposition') {
        //alert(location.href.split('sign=')[1].split('&rid=')[1]);
        geto_all_rep(topic_id, 50, 50);
    }

    // 统计用户点击推荐文章行为
    $('.promotion .new_info_con a').click(function() {
        var _this = $(this),
                tid = _this.attr('tid'),
                type = _this.attr('type');
        _this.attr('target', '_blank');
        _this.attr('href', _domain_bbs + 'topic/' + tid);
//        $.post(_domain_bbs + 'ajax.php?act=ajaxClickCnt', {type: type}, function(data) {
//        }, 'json');
    });

    // 
    var new_info_con = $('.new_info_con');
    new_info_con.each(function() {
        var sLink = $(this).find('a').text();
        var oNum = $(this).find('span');
        if ($(this).find('a').width() + oNum.width() < $(this).width()) {
            oNum.css({top: '0px'});
        } else {
            oNum.css({top: '20px'});
        }
    })
});
//禁言
function replay_gag_user(tid,rid,uid){
	if (!tid || !rid || !uid) {
        var box = new Boxy('<div> 参数错误！ </div>', {title: "", draggable: true, modal: false});
        setTimeout(function() {
            box.hide();
        }, 1000);
    }else{
	    objurl = urls_ajax + "?act=ajax07&tid=" + tid + "&rid=" + rid + "&uid=" + uid;
		 //objurl = urls_ajax + "?act=ajax07";
		$.post(objurl, function(data) {
		// $.post(url + 'api.php', {tid:tid, rid: rid,uid:uid}, function(data){
            if (data == 1) {
                _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;"> 禁言成功！ </div>', {modal: true});
                setTimeout(function() {
                    _boxy.hide();
                }, 3000);
            } else{
				_boxy = new Boxy('<div style="width:260px;height:60px;color:blue;"> 参数错误！ </div>', {modal: true});
                setTimeout(function() {
                    _boxy.hide();
                }, 3000);
			}
		});
	}
}
function share_weibo(link) {
    var edit_con = "哇！我在@派代网官方 看到一个超酷的评论：" + $(link).parents('dd').next('.reply_cont').children('.rc_text').text();
    var _appkey = encodeURI("801283809"),
            _assname = encodeURI("611962003");
    if (edit_con.length > 70) {
        edit_con = edit_con.slice(0, 70) + "...";
    }
    window.open("http://share.v.t.qq.com/index.php?c=share&a=index&url=" + window.location + "&appkey=" + _appkey + "&assname=" + _assname + "&title=" + edit_con);
}


//延迟加载图片函数
function delayLoadImg() {
    if (!$.browser.msie) {
        $("#reply_content img.avatar_img, #reply_logged_in img").lazyload({
            effect: 'fadeIn',
            placeholder: 'http://www.paidai.com/images/grey.gif?v=1',
            threshold: 250
        });
    } else {
        $("#reply_content img.avatar_img, #reply_logged_in img").each(function(i, img) {
            var original = $(img).attr('original');
            if (original) {
                $(img).attr('src', original);
            }
        });
    }
}

//回到上次浏览的地址
function backVistedY() {
    $('.pview_bar').fadeOut(1000);
    var url = $('#_floor_url').val();
    window.location.href = url;
}

//最终定位 =》回到上次浏览
function conVisitY() {
    var url = $('#_floor_url').val(),
            catid = $('#_cat_id').val();
    window.location.href = window.location = url + '#' + catid;
}

//检查是否需要自动加载
function check_isreload() {
    var topicid = $('#reply_iframe_topicid').val(),
            start = $('#reload_start').val(),
            offset = $('#reload_offset').val();
    if ($('#auto_reload_data').length > 0 && start != '') {
        if (($('#pid_' + max_repid).offset().top - $(window).height() - $(window).scrollTop()) < -600) {
            clearInterval(k_r);
            if ($('#cur_page_type').val() != 'n') {
                return geto_all_rep(topicid, start, offset);
            } else {
                return getn_all_rep(topicid, start, offset);
            }
        }
    } else {
        $('#page_limit').show();
        clearInterval(k_r);
    }
}

function keylistionscroll() {
    $(window).scroll(function() {
        if (_user_id != '') {
            if ($(window).scrollTop() > $("#cb").offset().top && $("#reply_list").find("dl").length >= 1) {
                var setYArray = [];
                var wsTop = $(window).scrollTop();
                $("#reply_list").find("dl").each(function(i) {
                    if ($(this).offset().top >= wsTop) {
                        setYArray.push($(this).attr("id").substring(4));
                        return false;
                    }
                });
                rep_visitid = setYArray.pop();
                if (!$.browser.msie) {
                    setScrollY();
                } else {
                    IesetScrollY();
                }
            }
        }
    });
}

var __pd_counter__ = 0;
function setScrollY() {
    __pd_counter__ += 1;
    $(window).unload(function() {
        var topicid = $('#reply_iframe_topicid').val(),
                replyid = rep_visitid;
        if (__pd_counter__ > 0) {
            $.post(_domain_bbs + 'api.php', {act: 'SetUserRecord', topicid: topicid, replyid: replyid}, function(data) {
            });
            __pd_counter__ = 0;
        }
    });
}
;

function IesetScrollY() {
    __pd_counter__ += 1;
    window.attachEvent('onunload', function() {
        var topicid = $('#reply_iframe_topicid').val(),
                replyid = rep_visitid;
        if (__pd_counter__ > 0) {
            $.post(_domain_bbs + 'api.php', {act: 'SetUserRecord', topicid: topicid, replyid: replyid}, function(data) {
            });
            __pd_counter__ = 0;
        }
    });
}
;


// 显示全部回复内容
$(function() {
    $(".vall_a").unbind('click').bind('click', function() {
        $(this).parent().hide();
        $(this).parent().parent().find(".vall_data").fadeIn("slow");
    });
    //自动加载回复
    (function() {
        $.defer = function(options) {
            var settings = {
                threshold: 100,
                delay: 1000,
                interval: 500
            };
            if (options) {
                $.extend(settings, options);
            }
            // execute one time
            var t = setTimeout(function() {
                // execute one more time
                var ti = setInterval(function() {
                    // find pre-set element list
                    if ($("*[data-defer='true']").size() > 0) {
                        var deferElements = $("*[data-defer='true']");
                        $.each(deferElements, function() {
                            if (($(this).offset().top - $(window).height() - $(window).scrollTop()) <= settings.threshold) {
                                var topicid = $(this).attr('data-topicid') || '';
                                var limit = $(this).attr('data-limit') || '';
                                var offset = $(this).attr('data-offset') || '';
                                var func = $(this).attr('data-callback');
                                var result = false;
                                if (func != 'undefined') {
                                    eval("result = " + func + "('" + topicid + "','" + limit + "','" + offset + "');");
                                }
                                if (result != 'undefined' && result == true) {
                                    $(this).attr('data-defer', false);
                                }
                            }
                        });
                    } else {
                        // stop interval function
                        clearInterval(ti);
                    }
                }, settings.interval);
            }, settings.delay);
        };
    })(jQuery);
});

//编辑回复提示效果
$(function() {
    load_report_submit();
});

function load_report_submit() {
    $("#reply_content dl").hover(function() {
        if ($(this).find("dd .editor_menu").length < 1)
            return;
        $(this).find("dd em.fr").hide();
        $(this).find("dd .editor_menu").show();
        $(this).find("dd .c_gray").css({'color': '#369'});
    }, function() {
        if ($(this).find("dd .editor_menu").length < 1)
            return;
        $(this).find("dd em.fr").show();
        $(this).find("dd .editor_menu").hide();
        $(this).find("dd .c_gray").css({'color': '#969696'});
    });
}
/**
 * ajax 删除资讯
 *
 * @param integer lw_id
 **/
//自愿者删除回复过滤
function isVter(bid, topicid, postid, posterid, obj) {
    $('.reason').find('textarea').val('').end().css({top: function() {
            return $(obj).offset().top + 15 + 'px';
        }, left: function() {
            return $(obj).offset().left + 'px';
        }}).show();
    var cl = function() {
        $('.reason').hide();
        var reason = $('.reason textarea').val();
        if (reason == '') {
            alert('删除原因不能为空！');
        } else {
            del_reply(bid, topicid, postid, posterid, reason);
        }
    }
    $('.reason input:eq(0)').unbind().bind('click', cl);

    $('.reason input:eq(1)').click(function() {
        $('.reason').hide();
    })
}
//删除回复
function del_reply(bid, topicid, postid, posterid, reason) {
    if (bid != null && topicid > 0 && postid > 0) {
        var del_flg = window.confirm('确定是否删除？');
        if (del_flg) {
            $.post(urls_ajax + '?act=ajax_del_reply', {
                bid: bid,
                topicid: topicid,
                postid: postid,
                posterid: posterid,
                reason: (reason ? reason : '')
            }, function(data) {
                if (data['error'] == 203) {
                    show_message(data['message']);
                    $('#pid_' + postid).fadeOut();
                } else {
                    alert(data['message']);
                    return false;
                }
            }, 'json');
        }
    } else {
        alert('参数错误');
    }

}
function show_message(msg) {
    _boxy = new Boxy('<div width=600 height=400>' + msg + '</div>', {modal: true});
    setTimeout(function() {
        _boxy.hide();
    }, 2000);
}
// 回复列表中的顶功能
var support_this_rep_status = 0;
function support_this_rep(obj, parentid, boardid, postid, postuid) {   
    if (support_this_rep_status == 1) {
        return false;
    }
    support_this_rep_status = 1;
    _this = obj;
    var rep_supcnt = $('#post_support_num_' + postid).html();
    if (rep_supcnt == '') {
        rep_supcnt = 0;
    }
    $.get(urls_ajax + '?act=ajax_post_vote', {
        parentid: parentid,
        boardid: boardid,
        postid: postid,
        postuid: postuid,
        uid: uid
    }, function(data) {
        support_this_rep_status = 0;
        if (data['error'] == 201) {
            var num = _this.text().substring(1);
            
            if (_this.find("i").length > 0) {
                return false;
            }

            _this.append('<i style="display:none; font-style:normal; position:absolute; left:0;">+'+data['content']+'</i>');
            _this.find("i").css("left", parseInt(_this.width() / 2));

            if (num == "" || parseInt(num) < 4)
            {
                _this.find("i").css("color", "#969696");
                if (num == "") {
                    _this.find("i").css("left", -3);
                }
            } else if (parseInt(num) >= 4) {
                _this.find("i").css("color", "#ff7b00");
            }
            _this.find("i").fadeIn(100, function() {
                $(this).animate({top: -15}, "show", function() {
                    $(this).fadeOut("hide", function() {
                        $(this).remove();
                        if (num == "")
                        {
                            if(parseInt(data['content'])<4){
                               _this.text('+'+data['content']);
                                _this.removeClass("praise_a1");
                                _this.addClass("praise_a2");
                                _this.attr("title", data['content']+"个赞"); 
                            }else{
                                _this.text("+" + parseInt(parseInt(data['content'])));
                                _this.removeClass("praise_a2");
                                _this.addClass("praise_a3");
                                _this.attr("title", (parseInt(data['content'])) + "个赞");
                            }
                            
                        } else if (parseInt(num)+parseInt(data['content']) < 4) {
                            _this.text("+" + parseInt(parseInt(num) + parseInt(data['content'])));
                            _this.attr("title", (parseInt(num) + parseInt(data['content'])) + "个赞");
                        } else if (parseInt(num)+parseInt(data['content']) >= 4) {
                            _this.text("+" + parseInt(parseInt(num) + parseInt(data['content'])));
                            _this.removeClass("praise_a2");
                            _this.addClass("praise_a3");
                            _this.attr("title", (parseInt(num) + parseInt(data['content'])) + "个赞");
                        }
                    });
                });
            });
        } else if (data['error'] == 200) {
            ajax_login();
            return false;
        } else if (data['error'] == 203) {
            alert(data['message']);
            return false;
        } else {
            alert(data['message']);
            return false;
        }
    }, 'json');
}

// 头像提示详细信息
// <em class="avatar_img"><img class="avatar_img_%uid%" /></em>
function userInfo_layer_addfollow(uid) {
    $.getJSON(_domain_my + 'api.php?jsoncallback=?', {act: 'follow', uid: uid}, function(data) {
        if (data['status'] == 201) {
            $('#userInfo_layer dl dd.dd_btn strong.attention_btn').hide();
            $('#userInfo_layer dl dd.dd_btn strong.clear_btn').show();
        } else {
            alert(data['msg']);
        }
    });
}
function userInfo_layer_removefollow(uid) {
    $.getJSON(_domain_my + 'api.php?jsoncallback=?', {act: 'removefollow', uid: uid}, function(data) {
        if (data['status'] == 201) {
            $('#userInfo_layer dl dd.dd_btn strong.attention_btn').show();
            $('#userInfo_layer dl dd.dd_btn strong.clear_btn').hide();
        } else {
            alert(data['msg']);
        }
    });
}

$(function() {
    $(".avatar_img").hoverIntent({
        interval: 200,
        over: function() {
            var obj = $(this),
                    clz = obj.attr('class'),
                    userInfo_layer = $('#userInfo_layer');
            if (userInfo_layer.length != 1 || !clz || clz.substring(0, 11) != 'avatar_img_') {
                return;
            }
            var uid = parseInt(clz.substring(11));
            $.getJSON(_domain_my + 'public_api.php?jsoncallback=?', {act: 'userinfo', uid: uid}, function(data) {
                if (data['errno'] == 0) {
                    var info = data['data'];
                    var relation = '',
                            btns = '',
                            homepage = '',
                            signure = '',
                            follow = false;
                    // 已登录
                    if (info['login'] == 1 && info['self'] == 0) {
                        if (info['relation'] >= 0) {
                            follow = true;
                            relation = '<strong class="attention_btn" style="display:none;">关注</strong><strong class="clear_btn" style="display:block;">取消</strong>';
                        } else {
                            relation = '<strong class="attention_btn" style="display:block;">关注</strong><strong class="clear_btn" style="display:none;">取消</strong>';
                        }
                        //<a href="javascript:;" onclick="newPm('+info['id']+');" title="派邮">派邮</a>
                        btns = '<p></p>';
                    }
                    if (info['homepage']) {
                        homepage = '<em>个人网站：<a href="' + info['homepage'] + '" target="_blank">' + info['homepage'] + '</a></em>';
                    }
                    if (info['signure']) {
                        signure = info['signure_cut'];
                    }
                    userInfo_layer.find('dl dt em').html('<a href="' + _domain_my + info['id'] + '" title="' + info['username'] + '"><img src="http://www.paidai.com/uploadpath/avatars/' + info['avatar'] + '" onerror="this.onerror=null;this.src=\'http://www.paidai.com/uploadpath/avatars/defavatar.gif\';" alt="' + info['username'] + '" /></a>');

                    userInfo_layer.find('dl dd.dd_info').html('<em><a href="' + _domain_my + info['id'] + '" title="' + info['username'] + '">' + info['username'] + '</a></em><span>' + info['career'] + '</span><strong>关注<a href="' + _domain_my + info['id'] + '/following">' + info['follow'] + '</a>&nbsp;<font color="#d2d2d2">|</font>&nbsp;粉丝<a href="' + _domain_my + info['id'] + '/follower">' + info['fans'] + '</a></strong>');
                    userInfo_layer.find('dl dd.dd_btn').html(relation + '' + btns);
                    if (homepage || signure) {
                        userInfo_layer.find('div.user_summary').css({'border-top': '1px solid #e6e6e6'}).html('<p>' + signure + '</p>' + homepage).show();
                    } else {
                        userInfo_layer.find('div.user_summary').css({'border-top': '0'}).html('').hide();
                    }
                    if (info['login'] == 1 && info['self'] == 0) {
                        userInfo_layer.find('dl dd.dd_btn strong.attention_btn').bind('click', function() {
                            userInfo_layer_addfollow(info['id']);
                        });
                        userInfo_layer.find('dl dd.dd_btn strong.clear_btn').bind('click', function() {
                            userInfo_layer_removefollow(info['id']);
                        });
                    }
                    var userInfoLayerX = obj.offset().left - 5,
                            userInfoLayerY = obj.offset().top - 7;
                    userInfo_layer.fadeIn(200)
                            .css({"left": userInfoLayerX, "top": userInfoLayerY})
                            .hover(function() {
                        $(this).show();
                    }, function() {
                        $(this).fadeOut(100);
                    });
                } else {

                }

            });
        },
        out: function() {
        }});
});

//管理菜单提示效果
$(function() {
    /* ------------- 管理菜单 -------------- */
    var t = 200;
    var manage = $(".topic_mg");
    var mMessage = $(".topic_mg_menu");
    var isObj = false;
    function testHandler() {
        mMessage.hover(function() {
            mMessage.show();
        }, function() {
            mMessage.slideUp(t);
        });
    }
    manage.hover(function() {
        mMessage.slideDown(t);
    }, function(event) {
        var oPoint = document.elementFromPoint(event.clientX, event.clientY);
        if ($(oPoint).attr("class") != "topic_mg_menu") {
            mMessage.slideUp(t);
        } else {
            if (mMessage.is(":visible")) {
                testHandler();
            }
        }
    });
});
jQuery.fn.autoResize = function(options)
{
    var opts = {
        'width': 700,
        'height': 750
    };
    var opt = $.extend(true, {}, opts, options || {});
    width = opt.width;
    height = opt.height;
    $('img', this).each(function() {
        var image = new Image();
        image.src = $(this).attr('src');
        if (image.width > 0 && image.height > 0) {
            var image_rate = 1;
//            if( (width / image.width) < (height / image.height)){
            image_rate = width / image.width;
//            }else{
//                image_rate = height / image.height ;
//            }
            if (image_rate <= 1) {
                $(this).width(image.width * image_rate);
                $(this).height(image.height * image_rate);
// 1. 老帖不点击查看大图
// 2. 或者将 图片替换中 脚本去除， 统一用这里的
//                $(this).click(function(){
//                    this.style.cursor = 'pointer';
//                    window.open(this.src);
//                });
            }
        }
    });
};

$(document).ready(function() {
    $('div.bottom_t').autoResize({width: 660, height: 1100});

    /*-----------------  右侧发派邮  --------------------*/
    $(".pmail_tbox").focusin(function() {
        var _this = $(this);
        if (_this.val() == "给他发派邮...") {
            _this.val("");
            _this.animate({height: '110px'}, 300);
        }
        _this.next(".pmail_btn").show();
        _this.css({"color": "#323232", "resize": "none"});
        _this.bind("keyup", function() {
            if (_this.scrollTop() > 0) {
                _this.css({"height": _this.height() + _this.scrollTop(), "overflow": "hidden"});
            }
        });

        $(document).click(function(obj) {
            activeObj = document.activeElement;
            activeObj = $(activeObj);
            if (!(activeObj.is(".pmail_btn") || activeObj.is(".pmail_tbox"))) {
                if ($(".pmail_tbox").val() == "") {
                    $(".pmail_tbox").animate({"height": "20px"}, 300);
                    $(".pmail_tbox").val("给他发派邮...");
                    $(".pmail_tbox").css("color", "#c8c8c8");
                    $(".pmail_btn").fadeOut(300);
                    sendpm_status = 0;
                }
            }
        });

    });
});
//发派邮
var sendpm_status = 0;
function postPm(tuid) {
    if (sendpm_status != 0)
        return;
    sendpm_status = 1;

    if (!_user_id) {
        alert("请先登录！");
        return false;
    }
    // if($(".pmail_tbox").val() == ""){
    // alert("请输入内容！");
    // return false;
    // }
    var content = $('.pmail_tbox').val();
    $.post(_domain_bbs + 'api.php', {act: 'savepm', tuid: tuid, content: content}, function(data) {
        sendpm_status = 0;
        if (data['errno'] == 0) {
            $(".pmail_tbox").animate({"height": "20px"}, 300);
            $(".pmail_tbox").val("给他发派邮...");
            $(".pmail_tbox").css("color", "#c8c8c8");
            $(".pmail_btn").fadeOut(300);
        } else {
            if (data['errno'] == 504) {
                alert("p3以下用户每天只能向5位用户发送派邮。");
            } else {
                alert("发送失败！");
            }
            return false;
        }
    }, 'json');
}

// 收藏主题
function ajax_fav_topic(tid, _url, favCnt) {
    var obj = $('#t_title_info .fav_btn');
    var msg = '';
    $.getJSON(_url + '?ac=addfav&msg=ok&format=json&tid=' + tid + '&jsoncallback=?', function(data) {
        if (data.content == 1) {
            //msg = '收藏成功！';
            obj.hide();
            obj.next(".c_fav_btn").css("display", "inline-block");
            msg = '';
        } else if (data.content == 2) {
            msg = '收藏失败，参数错误！';
        } else if (data.content == 3) {
            ajax_login();
            return false;
            //msg = '您未登录，没有操作权限！';
        } else if (data.content == 4) {
            msg = '收藏失败！';
        } else if (data.content == 5) {
            msg = '您不能收藏自己的文章！';
        } else if (data.content == 6) {
            msg = '您已收藏过此文章！';
        } else {
            msg = '参数错误！';
        }
        if (msg != '') {
            _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;">' + msg + '</div>', {modal: true});
            setTimeout(function() {
                _boxy.hide();
            }, 2000);
        }

    });
    return false;
}

// 取消收藏主题
function ajax_remove_fav_topic(tid, _url, favCnt) {
    var obj = $('#t_title_info .c_fav_btn');
    var msg = '';
    $.getJSON(_url + '?ac=removefav&msg=ok&format=json&tid=' + tid + '&jsoncallback=?', function(data) {
        if (data.content == 1) {
            //msg = '收藏成功！';
            obj.hide();
            obj.prev(".fav_btn").css("display", "inline-block");
            msg = '';
        } else if (data.content == 2) {
            msg = '收藏失败，参数错误！';
        } else if (data.content == 3) {
            msg = '您未登录，没有操作权限！';
        } else if (data.content == 4) {
            msg = '收藏失败！';
        } else if (data.content == 5) {
            msg = '您不能收藏自己的文章！';
        } else if (data.content == 6) {
            msg = '您没有收藏过此文章！';
        } else {
            msg = '参数错误！';
        }
        if (msg != '') {
            _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;">' + msg + '</div>', {modal: true});
            setTimeout(function() {
                _boxy.hide();
            }, 2000);
        }

    });
    return false;
}

// 收藏回复
function ajax_fav_reply(tid, rid, _url, _this) {
    var msg = '';
    $.getJSON(_url + '?ac=addfav_reply&msg=ok&format=json&tid=' + tid + '&rid=' + rid + '&jsoncallback=?', function(data) {
        if (data.content == 1) {
            msg = '收藏成功！';
        } else if (data.content == 2) {
            msg = '收藏失败，参数错误！';
        } else if (data.content == 3) {
            ajax_login();
            return false;
            //msg = '您未登录，没有操作权限！';
        } else if (data.content == 4) {
            msg = '收藏失败！';
        } else if (data.content == 5) {
            msg = '您不能收藏自己的文章！';
        } else if (data.content == 6) {
            msg = '您已收藏过此文章！';
        } else {
            msg = '参数错误！';
        }
        if (msg != '') {
            _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;">' + msg + '</div>', {modal: true});
            setTimeout(function() {
                _boxy.hide();
            }, 2000);
        }
        if (msg == '收藏成功！') {
            $(_this).hide().next('.nofav').show();
        }
    });
    return false;
}

// 取消收藏主题
function ajax_remove_fav_reply(tid, rid, _url, _this) {
    var msg = '';
    $.getJSON(_url + '?ac=removefav_reply&msg=ok&format=json&tid=' + tid + '&rid=' + rid + '&jsoncallback=?', function(data) {
        if (data.content == 1) {
            //msg = '收藏成功！';
            msg = '取消收藏成功';
        } else if (data.content == 2) {
            msg = '取消收藏失败，参数错误！';
        } else if (data.content == 3) {
            msg = '您未登录，没有操作权限！';
        } else if (data.content == 4) {
            msg = '取消收藏失败！';
        } else if (data.content == 5) {
            msg = '您不能取消收藏自己的文章！';
        } else if (data.content == 6) {
            msg = '您没有收藏过此文章！';
        } else {
            msg = '参数错误！';
        }
        if (msg != '') {
            _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;">' + msg + '</div>', {modal: true});
            setTimeout(function() {
                _boxy.hide();
            }, 2000);
        }
        if (msg == '取消收藏成功') {
            $(_this).hide().prev().show();
        }
    });
    return false;
}

//jsonP 关注
function new_add_follow(uid, obj) {
    $.getJSON(_domain_my + 'api.php?jsoncallback=?', {act: 'follow', uid: uid}, function(data) {
        if (data['status'] == 201) {
            $(obj).hide();
            $(obj).next(".c_attention_a").css("display", "inline-block");
        } else {
            if(data['msg']=='请您登录后再操作'){
                ajax_login();
                return false;
            }else{
                alert(data['msg']);
            }
            
        }
    });
}

// jsonP 取消关注
function new_remove_follow(uid, obj) {
    $.getJSON(_domain_my + 'api.php?jsoncallback=?', {act: 'removefollow', uid: uid}, function(data) {
        if (data['status'] == 201) {
            $(obj).hide();
            $(obj).prev(".attention_a").css("display", "inline-block");
        } else {
            alert(data['msg']);
        }
    });
}
// 回复帖子
function replyPoster(post_id, poster_uid, poster, obj) {
    // 没有出现回复框， 默认判定为未登录
    if (!document.editPostForm) {
        window.location.href = 'http://www.paidai.com/user/login.php?_last_url=' + window.location.href;
    }

    var em = $(obj).find('em').html();
    if (em.length > 2) {
        // 调用回复帖子的回复
        $.get('');
    }

    document.fastReplyPostForm.elements['postid'].value = post_id;
    document.fastReplyPostForm.elements['poster'].value = poster;

    $("#fastReplyContent").focus();
    return false;
}

// 回复支持
click_suppose_rec = new Array();
function click_suppose(postID, postTab, type) {
    var obj_num = $('#post_support_num_' + postID);
    var obj_a = $('#post_support_' + postID);
    var _val = obj_num.html();
    _val = Number(_val);
    _val += 1;
    var _click_suppose_rec = uid + '_' + postID;
    if (jQuery.inArray(_click_suppose_rec, click_suppose_rec) >= 0) {
        var admin_list = new Array('308', '10929', '41175', '15080');
        if (jQuery.inArray(uid, admin_list) < 0) {
            return false;
        }
    }

    $.get(urls_ajax + '?act=ajax_post_vote', {pid: postID, table: postTab, type: type}, function(data) {
        if (data == 1) {
            obj_num.html(_val);
            click_suppose_rec[click_suppose_rec.length + 1] = _click_suppose_rec;
            return false;
        } else {
            msg = '出错啦！';
        }
        alert(msg);
    });

    obj_a.removeClass('post_vote');
    obj_a.addClass('post_voted');

    return false;
}

// msg
$(function() {
    var x = -51, t = 200;
    var btn = $(".at_btn");
    var msg = $(".at_msg");
    var at_msg_inner2 = $(".at_msg_inner2");
    btn.click(function(e) {
        e.stopPropagation();
        $.post(urls_ajax + '?act=ajax_reply_content', {pid: this.id, tid: topic_id, tab: topic_postTab}, function(data) {
            var content = data.content;
            if (content) {
                msg.hide();
                at_msg_inner2.html(content);

                var y = at_msg_inner2.height();
                if (y > 71) {
                    at_msg_inner2.css({"overflow": "auto", "overflowX": "hidden", "height": "54px"});
                }
                showOrHide(msg, x, y, e, t);
            }
        }, 'json');
        return false;
    });
    $(document).click(function() {
        msg.hide();
    });
});

//公用函数
function showOrHide(elem, x, y, e, t) {
    if (!elem.is(":visible")) {
        if (elem.height() <= 66) {
            elem.css({"top": (e.pageY - y - 50) + "px", "left": (e.pageX + x) + "px"}).fadeIn(t);
        } else {
            elem.css({"top": (e.pageY - 71 - 50) + "px", "left": (e.pageX + x) + "px"}).fadeIn(t);
        }
    } else {
        elem.hide();
    }
}

// fast reply
$(function() {
    var btn = $(".post_reply");
    var tip = $(".fast_reply");
    var fast_reply_content = $(".fast_reply_content");

    btn.click(function() {
        tip.hide();
        tip.css("z-index", "98");
        $(this).parents().eq(2).append(tip);
        tip.slideDown(400);

        var fastReplyContent = $("#fastReplyContent");
        fastReplyContent.focus();
        if (typeof(fastReplyContent.attr('selectionStart')) == "number") {
            fastReplyContent.attr('selectionStart', fastReplyContent.val().length);
            fastReplyContent.attr('selectionEnd', fastReplyContent.val().length);
        } else if (document.selection) {
            fastReplyContent.focus();
            var box = document.getElementById('fastReplyContent');
            var rng = box.createTextRange();
            rng.moveStart("character", fastReplyContent.val().length);
            rng.collapse(true);
            rng.select();
        }
    });
    var cl = $(".close");
    cl.click(function() {
        $(this).parents().eq(2).slideUp("fast");
    });
    return false;
});

// 回复隔行变色
$(function() {
    $("div.reply_box .main:even").css("background", "#FFFFFF");
    $("div.reply_box .main:odd").css("background", "#F8F8F8");
});

function content_detail() {
    t = 1500;
    var contents_excerpta = $('.contents_excerpta');
    var contents_detail = $('.contents_detail');
    contents_excerpta.hide();
    contents_detail.slideDown(t);
    return false;
}

// 对回复进行回复， 如果有回复则显示回复内容
function show_reply_box(topicid, postid, replynum) {
    if (!_user_id) {
        ajax_login();
        return;
    }
    var obj = $('#pid_' + postid);
    if (obj.length <= 0) {
        return;
    }
    var box = obj.find('dd .reply_tow');
    box.css('display', (box.css('display') == 'none' ? 'block' : 'none'));
    // 如果有回复， 那么则异步加载回复内容
    if (replynum > 0) {
        var ul = box.find('.rt_list'),
                li = ul.find('li');
        // 异步加载， 只加载一次
        if (li.length < 1) {
            $.ajax({
                url: _domain_bbs + 'api.php',
                data: {act: 'post_reply_list', topicid: topicid, postid: postid},
                dataType: 'jsonp'
            });
        }
    }
    $('#contents_reply_' + postid).focus();
}
// jsonp 方式获取 对回复的回复列表
function jsonP_post_reply_list(data) {
    if (typeof(data) != 'object' || data['status'] != 201) {
        return;
    }
    var li = '',
            ul = $('#pid_' + data['postid'] + ' dd .reply_tow .rt_list');
    $(data['data']).each(function(i, item) {
        if (!(uid != item['postuserid'] && item['islocked'] == 2)) {
            li += '<li><p class="rt_uinfo"><a class="c_blue2" href="' + _domain_my + item['postuserid'] + '" title="' + item['postusername'] + '" target="_blank">' + item['postusername'] + '</a>:</p>' +
                    '<div class="rt_content pdTxtEditorPre">' + item['contents'] + '</div>' +
                    '<a class="c_gray fr" href="javascript:;" onclick="reply_post_tuid(\'' + data['postid'] + '\', \'' + item['id'] + '\', \'' + item['postusername'] + '\');" title="回复" >回复</a>' +
                    '</li>';
        }
    });
    if (li.length > 0 && ul.length > 0) {
        ul.html(li);
        /* 回复列表效果 */
        $(".reply_tow li").hover(
                function() {
                    $(this).css("background", "#f2f2f2");
                    $(this).find("em").css("background-position", "left -18px");
                }, function() {
            $(this).css("background", "#f7f8f9");
            $(this).find("em").css("background-position", "left 3px");
        }
        );
    }
}

function reply_post_tuid(postid, replyid, username) {
    //alert(postid + '_' + replyid + '_' + username);
    var box = $('#pid_' + postid);
    if (box.length < 1)
        return;
    box.find('input[name="postid_t"]').val(replyid),
            box.find('input[name="poster_t"]').val(username);
    var textarea = box.find('textarea[name="data_content"]');
    var txt = textarea.val();
    var reg = new RegExp("^回复[^:]*:");
    if (reg.test(txt)) {
        textarea.val(txt.replace(reg, "回复@" + username + ":"));
    } else {
        textarea.val("回复@" + username + ":" + txt);
    }
    jQ_moveEnd(textarea);
    //textarea.focus();
}

//光标移到最后
function jQ_moveEnd(obj) {
    obj.caretToEnd();
    var len = obj.val().length;
    if (document.selection) {
        var sel = obj.createTextRange();
        sel.moveStart('character', len);
        sel.collapse();
        sel.select();
    } else if (typeof obj.attr('selectionStart') == 'number' && typeof obj.attr('selectionEnd') == 'number') {
        //obj.selectionStart = obj.selectionEnd = len;
        obj.attr('selectionStart', len);
        obj.attr('selectionEnd', len);
    }
}
/* 回复回复 */
var g_ajax_reply_submit = 0;
function ajax_reply_post(obj, sign) {
    if (!sign)
        sign = '';
    if (g_ajax_reply_submit == 1)
        return false;
    g_ajax_reply_submit = 1;
    obj = $(obj);
    var topicid = obj.find('input[name="topicid"]').val(),
            boardid = obj.find('input[name="boardid"]').val(),
            postid = obj.find('input[name="postid"]').val(),
            poster = obj.find('input[name="poster"]').val(),
            postid_t = obj.find('input[name="postid_t"]').val(),
            poster_t = obj.find('input[name="poster_t"]').val(),
            content = obj.find('textarea[name="data_content"]').val();
    $.post(_domain_bbs + 'ajax_post.php?act=reply', {
        topicid: topicid,
        boardid: boardid,
        postid: postid,
        poster: poster,
        postid_t: postid_t,
        poster_t: poster_t,
        data_content: content
    }, function(data) {
        g_ajax_reply_submit = 0;

        if (data['status'] == 201) {
            obj.find('input[name="postid_t"]').val('0');
            obj.find('input[name="poster_t"]').val('');
            obj.find('textarea[name="data_content"]').val('');

            if (postid_t > 0) {
                var tmp = $('<span style="position:absolute;right:90px;top:10px;color:#333;">回复成功</span>');
                tmp.appendTo(obj.find('.tips_div'));
                setTimeout(function() {
                    tmp.remove();
                }, 3000);
            } else {
                $.ajax({
                    url: _domain_bbs + 'api.php',
                    data: {act: 'post_reply_list', topicid: topicid, postid: postid},
                    dataType: 'jsonp'
                });
            }
            if (sign == 'best') {
                var byusername = obj.attr('byusername');
                var parentusername = obj.attr('parentusername');
                var _li = '';
                if (!byusername && !parentusername) {
                    _li += '<li>';
                    _li += '<span class="fl">';
                    _li += '<a class="blue" href="http://my.paidai.com/n/' + data.poster + '" title="' + data.poster + '" target="_blank">' + data.poster + '</a>';
                    _li += '<br /><span>' + data.content + '</span>';
                    _li += '</span>';
                    _li += '</li>';
                } else {
                    _li += '<li>';
                    _li += '<span class="fl">';
                    _li += '<a class="blue" href="http://my.paidai.com/n/' + data.poster + '" title="' + data.poster + '" target="_blank">' + data.poster + '</a>';
                    _li += '<span>' + data.content + '</span>';
                    _li += '<b>';
                    _li += '<a class="blue" href="http://my.paidai.com/n/' + (parentusername ? parentusername : byusername) + '" title="' + (parentusername ? parentusername : byusername) + '" target="_blank">' + (parentusername ? parentusername : byusername) + '</a>';
                    _li += '<font>:</font>';
                    _li += '<i>' + obj.parents('li').find('span:eq(0) span').text() + '</i>';
                    _li += '</b></span></li>';
                }

                $(".cr_reply_list ul").append(_li);
                obj.attr('byusername', '');
                obj.attr('parentusername', '');
                obj.hide();
            }
        } else {
            alert(data['msg']);
        }

    },
            'json'
            );
    return false;
}


//点击默认状态下的更多回复显示列表
var geto_more_rep_status = 0;
function geto_all_rep(topicid, de_Cnt, ot_Cnt) {
    if (geto_more_rep_status != 0)
        return;
    geto_more_rep_status = 1;
    $('.reply_more_box').hide();
    var loadimg = "<div class='load_img' style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').append(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_more_olist', topicid: topicid, start: de_Cnt, offset: ot_Cnt}, function(data) {
        if (data['status'] == 201) {
            $('#reply_list .load_img').remove();
            $(data['data']).appendTo('#reply_list');
            $("#reply_list img").lazyload({
                effect: 'fadeIn',
                placeholder: 'http://www.paidai.com/images/grey.gif?v=2',
                threshold: 250
            });
            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['cur'] != 0) {
                $.defer();
            } else {
                $('#page_limit').show();
            }
            load_report_submit();
            delayLoadImg();
            // 异步回复定位
            if (location.href.split('sign=')[1] && location.href.split('sign=')[1].split('&rid=')[0] == 'ajaxposition') {
                window.location.hash = 'pid_' + location.href.split('sign=')[1].split('&rid=')[1];
            }
            $('.page-sep-wrap').show();
        }
        geto_more_rep_status = 0;
    }, 'json');
    return true;
}
//点击默认状态下的更多回复显示列表
var getz_more_rep_status = 0;
function getz_all_rep(topicid, de_Cnt, ot_Cnt) {
    if (getz_more_rep_status != 0)
        return;
    getz_more_rep_status = 1;
    $('.reply_more_box').hide();
    var loadimg = "<div class='load_img' style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').append(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_more_zlist', topicid: topicid, start: de_Cnt, offset: ot_Cnt}, function(data) {
        if (data['status'] == 201) {
            $('#reply_list .load_img').remove();
            $(data['data']).appendTo('#reply_list');
            $("#reply_list img").lazyload({
                effect: 'fadeIn',
                placeholder: 'http://www.paidai.com/images/grey.gif?v=2',
                threshold: 250
            });
            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['cur'] != 0) {
                $.defer();
            } else {
                $('#page_limit').show();
            }
            load_report_submit();
            delayLoadImg();
            // 异步回复定位
            if (location.href.split('sign=')[1] && location.href.split('sign=')[1].split('&rid=')[0] == 'ajaxposition') {
                window.location.hash = 'pid_' + location.href.split('sign=')[1].split('&rid=')[1];
            }
            $('.page-sep-wrap').show();
        }
        geto_more_rep_status = 0;
    }, 'json');
    return true;
}


//点击最新状态下的更多回复显示列表
var getn_more_rep_status = 0;
function getn_all_rep(topicid, de_Cnt, ot_Cnt) {
    if (getn_more_rep_status != 0)
        return;
    getn_more_rep_status = 1;
    $('.reply_more_box').hide();
    var loadimg = "<div class='load_img' style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').append(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_more_nlist', topicid: topicid, start: de_Cnt, offset: ot_Cnt}, function(data) {
        if (data['status'] == 201) {
            $('#reply_list .load_img').remove();
            $(data['data']).appendTo('#reply_list');
            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['cur'] != 0) {
                $.defer();
            } else {
                $('#page_limit').show();
            }
            load_report_submit();
            delayLoadImg();
        }
        getn_more_rep_status = 0;
    }, 'json');
    return true;
}

//点击最新回复显示列表
var getn_all_rep_status = 0;
function order_newest(topicid) {
    if (getn_all_rep_status != 0)
        return;
    
    getn_all_rep_status = 1;
    var loadimg = "<div style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').prepend(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_nlist', topicid: topicid}, function(data) {
        if (data['status'] == 201) {

            $('#reply_content .reply_title li:first').attr('class', '');
            $('#reply_content .reply_title li:first').next().attr('class', 'cur');
            
            $('#reply_content .reply_title li:last').attr('class', '');
            $('#reply_list').html(data['data']);
            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['page']) {
                $('.reply_more_box').show();
                //$('.fr').hide();
                $('#reply_more').attr('onclick', '');
                $('#reply_more').unbind('click').bind('click', function() {
                    getn_all_rep(topicid, 50, 50);
                });
                $('#remain_num').html(data['page']);
            } else {
                $('.reply_more_box').hide();
            }
            if ($('.fr .page-sep').length > 0) {
                $('.fr .page-sep').html(data['pagehtml']);
            }
            load_report_submit();
            delayLoadImg();
            getn_all_rep_status = 1;
			getz_all_rep_status = 0;
            geto_all_rep_status = 0;
            gets_all_rep_status=0
            geto_follow_rep_status = 0;
        } else {
            alert(data['data']);
            getn_all_rep_status = 0;
        }
    }, 'json');
}
//点击按赞回复显示列表
var getz_all_rep_status = 0;
function order_zanlist(topicid) {
    if (getz_all_rep_status != 0)
        return;
    
    getz_all_rep_status = 1;
    var loadimg = "<div style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').prepend(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_zlist', topicid: topicid}, function(data) {
        if (data['status'] == 201) {

            $('#reply_content .reply_title li:first').attr('class', '');
            $('#reply_content .reply_title li:first').next().attr('class', '');
            
            $('#reply_content .reply_title li:last').attr('class', 'cur');
            $('#reply_list').html(data['data']);
            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['page']) {
                $('.reply_more_box').show();
                //$('.fr').hide();
                $('#reply_more').attr('onclick', '');
                $('#reply_more').unbind('click').bind('click', function() {
                    getz_all_rep(topicid, 50, 50);
                });
                $('#remain_num').html(data['page']);
            } else {
                $('.reply_more_box').hide();
            }
            if ($('.fr .page-sep').length > 0) {
                $('.fr .page-sep').html(data['pagehtml']);
            }
            load_report_submit();
            delayLoadImg();
			getz_all_rep_status= 1;
            getn_all_rep_status = 0;
            geto_all_rep_status = 0;
            gets_all_rep_status=0
            geto_follow_rep_status = 0;
        } else {
            alert(data['data']);
            getz_all_rep_status = 0;
        }
    }, 'json');
}
//点击最新回复显示嘉宾列表
var gets_all_rep_status = 0;
function order_newestlz(topicid) {
    if (gets_all_rep_status != 0)
        return;
    //alert(getn_all_rep_status);
    gets_all_rep_status = 1;
    var loadimg = "<div style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').prepend(loadimg);
    
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_nlzist', topicid: topicid,jb:jb}, function(data) {
        
        if (data['status'] == 201) {
            $('#reply_content .reply_title li:first').attr('class', '');
            $('#reply_content .reply_title li:first').next().attr('class', '');
            
            $('#reply_content .reply_title li:last').attr('class', 'cur');
            $('#reply_list').html(data['data']);
            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['page']) {
                $('.reply_more_box').show();
                //$('.fr').hide();
                $('#reply_more').attr('onclick', '');
                $('#reply_more').unbind('click').bind('click', function() {
                    getn_all_rep(topicid, 50, 50);
                });
                $('#remain_num').html(data['page']);
            } else {
                $('.reply_more_box').hide();
            }
			$('.reply_more_box').hide();
            if ($('.fr .page-sep').length > 0) {
                $('.fr .page-sep').html(data['pagehtml']);
            }
            load_report_submit();
            delayLoadImg();
            getn_all_rep_status = 0;
            geto_all_rep_status = 0;
            gets_all_rep_status=1;
            geto_follow_rep_status = 0;
        } else {
            alert(data['data']);
            getn_all_rep_status = 0;
        }
    }, 'json');
}
//点击默认状态的回复显示列表
var geto_all_rep_status = 0;
function order_deflaut(topicid) {
    if (geto_all_rep_status != 0)
        return;
    
    geto_all_rep_status = 1;
    var loadimg = "<div style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').prepend(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_olist', topicid: topicid}, function(data) {
        if (data['status'] == 201) {
            $('#reply_content .reply_title li:first').attr('class', 'cur');
            $('#reply_content .reply_title li:first').next().attr('class', '');
            $('#reply_content .reply_title li:last').attr('class', '');
            $('#reply_list').html(data['data']);

            //显示回复全部 从新绑定
            $(".vall_a").unbind('click').bind('click', function() {
                $(this).parent().hide();
                $(this).parent().parent().find(".vall_data").fadeIn("slow");
            });
            if (data['page']) {
                $('.reply_more_box').show();
                //$('.fr').hide();
                $('#reply_more').attr('onclick', '');
                $('#reply_more').unbind('click').bind('click', function() {
                    geto_all_rep(topicid, 50, 50);
                });
                $('#remain_num').html(data['page']);
            } else {
                $('.reply_more_box').hide();
            }
            if ($('.fr .page-sep').length > 0) {
                $('.fr .page-sep').html(data['pagehtml']);
            }
            load_report_submit();
            delayLoadImg();
            geto_all_rep_status = 1;
			getz_all_rep_status = 0;
            getn_all_rep_status = 0;
            gets_all_rep_status=0;
            geto_follow_rep_status = 0;
        } else {
            alert(data['data']);
            geto_all_rep_status = 0;
        }
    }, 'json');
}


//点击关注的人的回复显示列表
var geto_follow_rep_status = 0;
function my_followrep(topicid, uid) {
    if (geto_follow_rep_status != 0)
        return;
    geto_follow_rep_status = 1;
    var loadimg = "<div style='margin: 0 auto; width: 100%; text-align: center;'><img src='http://www.paidai.com/images/my/v6/loading02.gif' /></div>";
    $('#reply_list').prepend(loadimg);
    $.get(_domain_bbs + 'api.php', {act: 'ajax_get_follow_list', topicid: topicid, uid: uid}, function(data) {
        if (data['status'] == 201) {
            $('#reply_content .reply_title li:first').attr('class', '');
            $('#reply_content .reply_title li:last').attr('class', '');
            $('#reply_content .reply_title li:first').next().attr('class', 'cur');
            $('#reply_list').html(data['data']);
            if (!data['page']) {
                $('#reply_more').hide();
            } else {
                $('.reply_more_box').show();
                $('#reply_more').attr('onclick', '');
                $('#reply_more').unbind('click').bind('click', function() {
                    getf_all_rep(topicid, 50, 30);
                });
                $('#remain_num').html(data['page']);
            }
            load_report_submit();
            geto_follow_rep_status = 1;
            getn_all_rep_status = 0;
            geto_all_rep_status = 0;
        } else {
            alert(data['data']);
            geto_follow_rep_status = 0;
        }
    }, 'json');
}

var myboxy;
function newPm(uid) {
    $(".pop_frame").fadeIn("show");
    $(".pop_bg").fadeTo("show", 0.2);
    $(".pop_frame").css({"height": $(document).height()});
    $(".pop_bg").css({"height": $(document).height()});
    var fitMailX = ($(window).width() - $(".fit_mail").width()) / 2;
    var fitMailY = ($(window).height() - $(".fit_mail").height()) / 2 + $(window).scrollTop();
    $(".fit_mail").css({"left": fitMailX, "top": fitMailY});
    $(window).scroll(function() {
        fitMailX = ($(window).width() - $(".fit_mail").width()) / 2;
        fitMailY = ($(window).height() - $(".fit_mail").height()) / 2;
        $(".fit_mail").css({"left": fitMailX, "top": fitMailY + $(window).scrollTop()});
    });
    $(".pop_bg").click(function() {
        $(".pop_frame").fadeOut(200);
    });
    $(".fit_mail strong a").click(function() {
        $(".pop_frame").fadeOut(200);
    });
    if (arguments.length > 1) {
        var title = arguments[1];
        $('.fit_mail h3 em').html(title);
    }

    $('.fit_mail input.submit_btn').unbind('click').bind('click', function() {
        layer_postPm(uid);
    });
    return false;
}

var myboxy, layer_sendpm_status = 0;
function layer_postPm(tuid) {
    if (layer_sendpm_status != 0)
        return;
    layer_sendpm_status = 1;
    var content = $('.fit_mail textarea').val();
    $.post(_domain_bbs + 'api.php', {act: 'savepm', tuid: tuid, content: content}, function(data) {
        var box = new Boxy('<div>' + data['msg'] + '</div>', {
            title: "",
            draggable: true,
            modal: false
        });
        setTimeout(function() {
            box.hide();
        }, 1000);
        if (data['errno'] == 0) {
            $('.fit_mail textarea').val('');
            $(".pop_frame").fadeOut(200);
        }
        layer_sendpm_status = 0;
    }, 'json');
}


function closeNewPm() {
    if ('object' == typeof(myboxy) && true === myboxy.isVisible()) {
        myboxy.hide();
    }
}

/**
 * 举报回复pop
 *
 * @since 2011-11-30 chenchuanyao@paidai.com
 *
 */
var report_box = null;
function report_reply(tid, rid, uid) {

    if (!tid || !rid || !uid) {
        var box = new Boxy('<div> 参数错误！ </div>', {title: "", draggable: true, modal: false});
        setTimeout(function() {
            box.hide();
        }, 1000);
    }
    report_box = new Boxy($('#report_box').show(), {modal: true});
    $('#tid').val(tid);
    $('#rid').val(rid);
    $('#uid').val(uid);

    return false;
}

/**
 * ajax 提交简历提问
 **/
function submit_report(obj) {
   
    var tid = $('#tid').val();
    var rid = $('#rid').val();
    var uid = $('#uid').val();
    
    var report_content = $('input[name="content"]:checked').val();;
     
    if (report_content && tid && rid && uid) {
        report_box.hide();

        objurl = urls_ajax + "?act=ajax05&tid=" + tid + "&rid=" + rid + "&uid=" + uid + "&report_content=" + report_content;
        $.post(objurl, function(data) {
            if (data == 3) {
                _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;"> 举报成功！ </div>', {modal: true});
                setTimeout(function() {
                    _boxy.hide();
                }, 3000);
            } else if (data == 2) {
                _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;"> 系统出错！ </div>', {modal: true});
                setTimeout(function() {
                    _boxy.hide();
                }, 3000);
            } else if (data == 5) {
                _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;"> 您已经举报了该回复，管理员正在处理中</div>', {modal: true});
                setTimeout(function() {
                    _boxy.hide();
                }, 3000);
            } else {
                _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;"> 参数错误！ </div>', {modal: true});
                setTimeout(function() {
                    _boxy.hide();
                }, 3000);
            }
        });
    }
    return false;
}

/**
 * 关闭举报回复pop
 *
 */
function close_report_box() {
    report_box.hide();
    $('#tid').val('');
    $('#rid').val('');
    $('#uid').val('');
}

/**
 * 取得原始图片地址
 * 
 * @param $src rewrited img's src path
 * @retrun string 
 * @author CQ.H@paidai.com
 */
function getImgOriginalSrc($src) {
    // 有规定图片后缀[jpg/png/gif]结尾的不做处理
    var $pos1 = $src.indexOf('.jpg');
    var $pos2 = $src.indexOf('.JPG');
    var $pos3 = $src.indexOf('.png');
    var $pos4 = $src.indexOf('.PNG');
    var $pos5 = $src.indexOf('.gif');
    var $pos6 = $src.indexOf('.GIF');
    if ($pos1 > 0 || $pos2 > 0 || $pos3 > 0 || $pos4 > 0 || $pos5 > 0 || $pos6 > 0)
        return $src;

    // 不是本站域名图片的不做处理
    if ($src.indexOf('.paidai.com') < 0)
        return $src;

    var $s = $src.replace('thumbnail/2', 'uploadpath');
    var $i = $s.indexOf('/', 34);
    if ($i != -1) {
        $rs = $s.substring(33, $i);
        var $map = {
            'g': '.gif',
            'p': '.png',
            'O': '_',
            'z': '-',
            'o': '/',
            'A': 'avatar_',
            'j': '.jpg'
        };
        for (var $k in $map) {
            $rs = $rs.replace($k, $map[$k]);
        }
        return $s.substring(0, 33) + $rs;
    } else {
        return false;
    }
}

//-----------------------------图片放大弹层------------------------------//
$(document).ready(function() {
    if ($("imglayer_bg")[0] == null) {
        $("body").append('<div id="imglayer_bg"></div><div id="imglayer_border"><a href="javascript:;" id="imglayer_x" hidefocus="true" ></a><img id="imglayer_zoom" src="http://www.paidai.com/images/bbs/topic/imglayer_loading.gif" /></div>');
    }

    var docW = window.document.documentElement.clientWidth,
            docH = window.document.documentElement.clientHeight,
            imgBg = $('#imglayer_bg'),
            imgBorder = $('#imglayer_border'),
            startX = 0,
            startY = 0,
            dragObj = document.getElementById('imglayer_border'),
            dragTop = 0,
            dragLeft = 0;

    //点击图片显示弹层 --文章内容部分
    $('#topic_content').click(function(e) {
        var target = e.target || e.srcElement;
        if (target.tagName == 'IMG' && target.getAttribute('noOriginal')==null) {
            var url = target.getAttribute('original') || target.src;
            loadOriginalImg(url);
        }
    });

    function loadOriginalImg($src) {
        imgBg.fadeTo('fast', 0.7).css('background-position', 'center center');
        var img = document.getElementById('imglayer_zoom');
        img.parentNode.removeChild(img);
        var newImg = new Image();
        newImg.id = 'imglayer_zoom';
        imgBorder.append(newImg);
        newImg.onload = function() {
            var newImg = document.getElementById('imglayer_zoom');
            imgBorder.fadeIn('fast').css({'top': (docH - newImg.clientHeight - 50) / 2, 'left': (docW - newImg.clientWidth - 50) / 2});
            imgBg.css('background-position', '0 5000px');
            //top
            if ($(newImg).height() > $(window).height())
            {
                var top_val = parseInt($(window).scrollTop() - $('#imglayer_border').offset().top);
                $('#imglayer_x').css({"top": top_val - 10});
            } else if ($(newImg).width() > $(window).height())
            {
                var right_val = parseInt($(window).scrollLeft() - $('#imglayer_border').offset().left);
                $('#imglayer_x').css({"right": right_val - 10});
            }

            //right
            if ($(newImg).width() > $(window).width())
            {
                var right_val = parseInt([$('#imglayer_border').width() + $('#imglayer_border').offset().left] - $(window).width());
                $('#imglayer_x').css({"right": right_val});
            } else if ($(newImg).width() > $(window).height())
            {
                $('#imglayer_x').css({"right": -20});
            }

            //双击关闭
            $('#imglayer_border').dblclick(function(e) {
                imgBorder.fadeOut('fast');
                imgBg.fadeOut('fast', function() {
                    $('#imglayer_x').css({"top": -20, "right": -20});
                });
            });

        };
        newImg.src = getImgOriginalSrc($src);
    }

    //点击图片显示弹层 --回复部分
    $('#reply_list').click(function(e) {
        var target = e.target || e.srcElement;
        if (target.tagName == 'IMG') {
            var width = parseInt(target.width);
            if (width >= 100) {
                loadOriginalImg(target.src);
            }
        }
    });



    //点击X关闭弹层
    $('#imglayer_x').click(function() {
        imgBorder.fadeOut('fast');
        imgBg.fadeOut('fast', function() {
            $('#imglayer_x').css({"top": -20, "right": -20});
        });
    });

    //点击背景关闭弹层
    $('#imglayer_bg').click(function(e) {
        var target = e.target || e.srcElement;
        if (target.id == 'imglayer_bg') {
            $(this).fadeOut('fast');
            imgBorder.fadeOut('fast', function() {
                $('#imglayer_x').css({"top": -20, "right": -20});
            });
        }
    });


    //拖动图片弹层-开始
    $('#imglayer_border').mousedown(function(e) {
        var event = e || window.event;
        event.preventDefault();
        window.getSelection ? window.getSelection().removeAllRanges() : document.selection.empty();
        startX = event.screenX;
        startY = event.screenY;
        dragTop = parseInt(dragObj.style.top);        //内联样式，由fadeIn语句设定
        dragLeft = parseInt(dragObj.style.left);
        $(document).bind('mousemove', dragMove);
        $(document).bind('mouseup', dragOver);
    });

    //拖动
    function dragMove(e) {
        var event = e || window.event;
        event.preventDefault();
        dragObj.style.left = dragLeft + event.screenX - startX + 'px';
        dragObj.style.top = dragTop + event.screenY - startY + 'px';
        // top
        if ($(window).scrollTop() >= $(dragObj).offset().top)
        {
            var top_val = parseInt($(window).scrollTop() - $('#imglayer_border').offset().top);
            $('#imglayer_x').css({"top": top_val - 10});
        } else {
            $('#imglayer_x').css({"top": -20});
        }
        // right
        if ($(window).width() < parseInt($('#imglayer_border').offset().left + $('#imglayer_border').width()))
        {
            var right_val = parseInt([$('#imglayer_border').width() + $('#imglayer_border').offset().left] - $(window).width());
            $('#imglayer_x').css({"right": right_val});
        } else {
            $('#imglayer_x').css({"right": -20});
        }
    }
    ;

    //结束
    function dragOver() {
        $(document).unbind('mousemove', dragMove).unbind('mouseup', dragOver);
    }
    ;
});


$(function() {
    /*
     * 神回复
     */
    if ($('.cr_list').find('dl').length > 3)
    {
        var prev_btn = $('#cow_reply .cr_list .prev_btn'),
                next_btn = $('#cow_reply .cr_list .next_btn'),
                _left = 0, _right = 1;

        // 鼠标放上
        $('.cr_list').bind('mouseover', function() {
            if (_left == 0) {
                next_btn.show();
                prev_btn.hide();
            } else if (_right == 0) {
                prev_btn.show();
                next_btn.hide();
            } else {
                next_btn.show();
                prev_btn.show();
            }
        });
        // 鼠标离开
        $('.cr_list').bind('mouseout', function() {
            prev_btn.hide();
            next_btn.hide();
        });

        prev_btn.hover(function() {
            $(this).fadeTo(0, 0.6);
        }, function() {
            $(this).fadeTo(0, 0.3);
        });
        next_btn.hover(function() {
            $(this).fadeTo(0, 0.6);
        }, function() {
            $(this).fadeTo(0, 0.3);
        });

        // 下一页按钮点击事件
        next_btn.click(function() {
            var box_left = $('.cr_list table').css('left');
            var x = parseInt(box_left).toString().substring(1) || parseInt(box_left);
            var last_num = [parseInt(parseInt($('.cr_list table').width()) - 223 * 3) - parseInt(x)] / 223;
            if (parseInt(x) % 223 != 0) {
                return false;
            } // 如果动画没运行完就停止执行下面的事件
            if (parseInt(x) < parseInt(parseInt($('.cr_list table').width()) - 223 * 3))
            {
                prev_btn.show();
                _left = 1;
                if (last_num == 1) {
                    $('.cr_list table').animate({left: parseInt(box_left) - 223 * 1}, 'show');
                } else if (last_num == 2) {
                    $('.cr_list table').animate({left: parseInt(box_left) - 223 * 2}, 'show');
                } else if (last_num >= 3) {
                    $('.cr_list table').animate({left: parseInt(box_left) - 223 * 3}, 'show');
                }
                if (last_num <= 3) {
                    $(this).hide();
                    _right = 0;
                }
            } else {
                $(this).hide();
                return _right = 0, _left = 1;
            }
        });

        // 上一页按钮点击事件
        prev_btn.click(function() {
            var box_left = $('.cr_list table').css('left');
            var x = parseInt(box_left).toString().substring(1) || parseInt(box_left);
            var first_num = [parseInt(x)] / 223;
            if (parseInt(x) % 223 != 0) {
                return false;
            } // 如果动画没运行完就停止执行下面的事件
            if (parseInt(box_left) < 0)
            {
                next_btn.show();
                _right = 1;
                if (first_num == 1) {
                    $('.cr_list table').animate({left: parseInt(box_left) + 223 * 1}, 'show');
                } else if (first_num == 2) {
                    $('.cr_list table').animate({left: parseInt(box_left) + 223 * 2}, 'show');
                } else if (first_num >= 3) {
                    $('.cr_list table').animate({left: parseInt(box_left) + 223 * 3}, 'show');
                }
                if (first_num <= 3) {
                    $(this).hide();
                    _left = 0;
                }
            } else {
                $(this).hide();
                return _left = 0, _right = 1;
            }
        });

    }

    // 判断热门回复的个数
    if ($('.cr_list').find('dl').length >= 3)
    {
        $('.cr_list').find('td').css({'width': '223px'});
        $('.cr_list').find('td dl').css({'width': '222px'});
    }

    // 列表鼠标感应
    $('.cr_list').find('td').hover(
            function()
            {
                $(this).css({'background-color': '#FCFCFC'});
            },
            function()
            {
                $(this).css({'background-color': ''});
            }
    );

    // 列表点击显示当前回复内容

    var rids = [];
    $(".cr_list dl").bind('click', function(e) {
        e ? e.stopPropagation() : window.event.cancelBubble = true;
        var rid = $(this).attr('rid');
        var tid = $(this).attr('tid');
        var _this = $(this);

        if ($('.cr_list').find('dl').length > 3)
        {
            $('.cr_list').find('dl.cur_reply').css({'width': '222px'});
            $(this).css({'width': '223px'});
        }

        if ($("#cow_reply .cr_reply_detail[rid='" + rid + "']:visible").length > 0) {
            _this.removeClass('cur_reply');
            $("#cow_reply .cr_reply_detail[rid='" + rid + "']").hide();
            if ($(".reply_text_box_one:visible").length > 0) {
                $(".reply_text_box_one:visible").hide();
            }
        } else {
            replyShOrHide(rid, tid, _this);
        }

        //$('.cr_reply_detail').find('dl').hide();
        //$('.cr_reply_detail').find('#rid' + _this.attr('rid')).show();
    })

    function replyShOrHide(rid, tid, _this) {
        $('.cr_list').find('dl.cur_reply').removeClass('cur_reply');
        _this.addClass('cur_reply');
        if (jQuery.inArray(rid, rids) != -1) {
            $("#cow_reply .cr_reply_detail[rid='" + rid + "']").show();
            $("#cow_reply .cr_reply_detail[rid!='" + rid + "']").hide();
            if ($(".cr_list dl").length == 1) {
                $("#cow_reply .cr_reply_detail[rid='" + rid + "'] dl dt").hide();
                $("#cow_reply .cr_reply_detail[rid='" + rid + "'] dl dd:eq(0)").hide();
            }
        } else {
            $.getJSON(_domain_bbs + 'api.php', {act: 'ajaxGetBestReplies', rid: rid, tid: tid}, function(data) {
                $("#cow_reply").append(data.content.htm);
                $("#cow_reply .cr_reply_detail[rid='" + data.content.rid + "']").show();
                $("#cow_reply .cr_reply_detail[rid!='" + data.content.rid + "']").hide();
                replyAClickHandler();
                if ($(".cr_list dl").length == 1) {
                    $("#cow_reply .cr_reply_detail[rid='" + data.content.rid + "'] dl dt").hide();
                    $("#cow_reply .cr_reply_detail[rid='" + data.content.rid + "'] dl dd:eq(0)").hide();
                }
            })
            rids.push(rid);
        }
    }

    /*
     * 热门回复 -- 回复
     */
    function replyAClickHandler()
    {
        $('.reply_a').click(function(e) {
            e ? e.stopPropagation() : window.event.cancelBubble = true;
            var replyTextBox = $(this).parents("dl").find(".reply_text_box"),
                    textearea = replyTextBox.find(".reply_textarea");
            replyTextBox.find('input[name="postid"]').val('');
            replyTextBox.find('input[name="poster"]').val('');
            replyTextBox.find('input[name="postid"]').val($(this).parents('li').attr('rid'));
            replyTextBox.find('input[name="poster"]').val($(this).attr('puname'));

            if ($(this).parents('li').find('span a').length > 1) {
                replyTextBox.attr('parentusername', $.trim($(this).parents('li').find('span a:eq(0)').text()));
                replyTextBox.attr('byusername', $(this).attr('loginuser'));
            } else {
                replyTextBox.attr('parentusername', $.trim($(this).parents('li').find('span a:eq(0)').text()));
                replyTextBox.attr('byusername', '');
            }

            $(this).parents('li').append(replyTextBox);
            replyTextBox.show();
            replyTextBox.css({"margin": "5px 0px 5px 0px"});
            textearea.focus();
            jQ_moveEnd(textearea);
        });

        $(".cr_reply_detail .tr_operate_bar .reply_a").unbind('click');
        $(".cr_reply_detail .tr_operate_bar .reply_a").click(function(e) {
            e ? e.stopPropagation() : window.event.cancelBubble = true;
            var replyTextBox = $(this).parents("dl").find(".reply_text_box"),
                    textearea = replyTextBox.find(".reply_textarea");

            replyTextBox.find('input[name="postid"]').val('');
            replyTextBox.find('input[name="poster"]').val('');
            replyTextBox.find('input[name="postid"]').val($('.cr_reply_detail:visible').attr('rid'));
            replyTextBox.find('input[name="poster"]').val($('.best_reply_uname:visible').attr('title'));

            $(this).parents('dd').next(".cr_reply_list").prepend(replyTextBox);
            replyTextBox.css({"margin": "10px 20px 0px 0px", "display": "inline"});
            replyTextBox.show();
            textearea.focus();
            textearea.val("");
        });
    }

    //光标移到最后
    function jQ_moveEnd(obj) {
        obj.caretToEnd();
        var len = obj.val().length;
        if (document.selection) {
            var sel = obj.createTextRange();
            sel.moveStart('character', len);
            sel.collapse();
            sel.select();
        } else if (typeof obj.attr('selectionStart') == 'number' && typeof obj.attr('selectionEnd') == 'number') {
            obj.attr('selectionStart', len);
            obj.attr('selectionEnd', len);
        }
    }
    replyAClickHandler();

    // 当只有一条神回复时
    $(".main_reply_a").bind('click', function(e) {
        e ? e.stopPropagation() : window.event.cancelBubble = true;
        var rid = $(this).parents('dl').attr('rid');
        var tid = $(this).parents('dl').attr('tid');
        var _this = $(this).parents('dl');
        replyShOrHide(rid, tid, _this);
        $(this).parents(".cr_list").css('height', 'auto');
        $(this).parents("dl").css('height', 'auto');
        var replyTextBox = $(this).parents("dd").find(".reply_text_box_one");
        replyTextBox.show();
        replyTextBox.find('.reply_textarea').focus();
    });
    $('.reply_text_box_one').add($("#cow_reply")).add($('.main_support')).bind('click', function(e) {
        e ? e.stopPropagation() : window.event.cancelBubble = true;
    })
    $("body").not($("#cow_reply")).click(function(e) {
        $("#cow_reply form").hide();
    });

    $(".allowTopicClosed2").bind('click', function(){
        var topicid = $(this).attr('topicid');
        if(!topicid) {
            alert('无效主题');
            return;
        }
        var _this = $(this);
        var url = _domain_bbs || 'http://bbs.paidai.com';
        $.post(url + 'api.php', {act:'allowTopic', topicid: topicid}, function(data){
            if(data['error'] == 0) {
                $('#denyTopicBox').html('已通过');
                return;
            }
            alert(data['message']);
        }, 'json');
    });

    $(".allowReplyClosed2").bind('click', function(){
        var topicid = $(this).attr('tid'),
            replyid = $(this).attr('rid');
        if(!replyid || !topicid) {
            alert('无效回复');
            return;
        }

        var _this = $(this);
        var url = _domain_bbs || 'http://bbs.paidai.com';
        $.post(url + 'api.php', {act:'allowReply', topicid: topicid, replyid: replyid}, function(data){
            if(data['error'] == 0) {
                $('#denyReplyBox_'+replyid).hide();
                _this.hide();
                return;
            }
            alert(data['message']);
        }, 'json');
    });

    

});
