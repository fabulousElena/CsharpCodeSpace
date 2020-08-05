
var Lite_API = "http://www.tianya.cn/api/tw";

//发布框控制
function initBuluoPost(){
    TY.loader('TY.ui.bbsPost',function(){
	    TY.ui.bbsPost.prototype.insertPhoto = function(args){
	        var liEl = jQuery("#post_picPreview").find("li"),
	            size = liEl.size();
	        if(size >= 5){
	            alert("一次最多发布5张图片.");
	        }else{
	            var html = ''
	            for (var i=0,len=args.length; size < 5 && i<len; i++) {
	                html += '<li class="picPreviewItem">' +
	                            '<label>描述：<input maxlength="100" class="pic_desc"  type="input" value="" name="picDesc'+size+'"/></label>' +
	                            '<input class="pic_val" readOnly type="input" value="'+args[i]['mid']+'" name="picUrl'+size+'"/>' +
	                            '<a href="javascript:;" class="picPreviewDel" title="删除图片">删除</a>' +
	                        '</li>';
	                size ++;
	            }
	            jQuery("#post_picPreview").append(html);
	        }
	    };
	    window.buluoPostObj = new TY.ui.bbsPost({
	        BBSObj : 'buluoPostObj',
	        el : jQuery("#FormResponse"),
	        toolWrap : jQuery('#editorToolBar'),
	        plugins : "friend,photo"
	    });
	    jQuery('.picPreviewDel').live('click',function(){
	        jQuery(this).parent().remove();
	    });
	});

    //提交按钮
    jQuery("#sendBtn2").click(function(event){
        if(!__global.isOnline()){
            TY.loginAction();
            return false;
        }
        var val = jQuery("#content").val();
        if(jQuery.trim(val) === ""){
            event.preventDefault();
            alert("请填写回复内容。");
            return false;
        }
    });
    //ctrl+enter
    jQuery('#content').keypress(function(e){
        if((e.which === 10) || (e.which === 13&&e.ctrlKey === true)){
            jQuery("#sendBtn2").click();
        }
    });
}

function replyToAuthor(){
    jQuery("#content").val("@" + getArticleProperty("writer") + " ");
    setTimeout(function(){
        jQuery("#content").focus();
    },500);
}

//回复帖子
function initReplyId(){
    jQuery(".replayToId").click(function(e){
        e.preventDefault();
        jQuery("a[name='fabu_anchor']").get(0).scrollIntoView();
        var replyBox = jQuery(this).closest(".replyContentBox"),
            contentId = jQuery(this).attr("_replayId"),
            contentDivId = document.getElementById("content" + contentId),
            floorId = document.getElementById("floor" + contentId),
            textareaContentId = document.getElementById("content"),
            val = '';
        if(textareaContentId){
             val = "@" + replyBox.find(".js-vip-check").text()
                + "　　" + floorId.innerHTML + "\n"
                + removeHTMLTag(contentDivId.innerHTML.replace(/<br>/gi,"\n"));
	        textareaContentId.value = jQuery.trim(val)
	                + "\n-----------------------------\n";
	        setTimeout(function(){
	            textareaContentId.focus();
	        },500);
        }
    });
    jQuery(".js_replyTo_author").click(function(e){
        e.preventDefault();
        jQuery("a[name='fabu_anchor']").get(0).scrollIntoView();
        replyToAuthor();
    });
}

//帖子收藏
function initCollectArticle(){
    jQuery(".js_collect_post").click(function(e){
        e.preventDefault();
        
        if(!__global.isOnline()){
            TY.loginAction();
            return;
        }
        var params= {
            "method":"collect.ice.addCollectArticle",
            "params.appName": "来吧",
            "params.articleTime": getArticleProperty("articleTime"),
            "params.title": getArticleProperty("articleTitle"),
            "params.url": getArticleProperty("articleUrl"),
            "params.articleUserId": getArticleProperty("idwriter"),
            "params.articleUserName": getArticleProperty("writer"),
            "params.from": "天涯来吧",
            "params.fromUrl": getArticleProperty("articleUrl"),
            "var": "collectArticleVar" 
        };
        jQuery.getScript(Lite_API + "?" + jQuery.param(params),function(){
            var rnt = window['collectArticleVar'],
                type = "success";
            if( rnt && rnt.success){
                type = "success";
            }else{
               type = "failure";
            }
            TY.loader("TY.ui.tips",function(){
                new TY.ui.tips({
                    "el": jQuery("#firstAuthor").find(".writer_header_op"),
	                'msg':rnt && rnt.message || "收藏失败！",
	                'position':'midCenter',
	                'time':2500
	            });
            })
        });
    });
}

function bindSelPosition(_op){
    var $ = jQuery;
    var hidetimeout = false;
    var op = {
        parent : null,
        box : null,
        top : 0,
        left : 0,
        directionLeft : 0
    }
    
    $.extend(op, _op || {});
    
    function hideView(){
        op.box.hide();
        hidetimeout = false;
    }
    
    op.parent.bind("mouseenter",function(){
        if (hidetimeout) {
            clearTimeout(hidetimeout);
        }
        else {
            var top=0,left=0;
            
            top = op.parent.offset().top+op.parent.height()+op.top;
            
            if (op.directionLeft){
                left = op.parent.offset().left + op.parent.outerWidth() - op.box.outerWidth();
            }else{
                left = op.parent.offset().left + op.left;
            }
            
            op.box.css({"top":top,"left":left});
            op.box.show();
        }
        
    }).bind("mouseleave",function(){
        hidetimeout = setTimeout(hideView,100);
    });
    
    op.box.bind("mouseenter",function(){
        if (hidetimeout) {
            clearTimeout(hidetimeout);
        }       
    }).bind("mouseleave",function(){
        hidetimeout = setTimeout(hideView,100);
    });
}
//分享按钮
function initShareBox($){
    var dMod = $("#shareBox");
    var selMod = $(".js_share_post");
    
    var shareBox = {
        shareData:{
            site:encodeURIComponent('天涯社区'),
            title:'',
            title_gbk:'',
            url:''
        },
        getPageData:function(){
            jQuery.extend(this.shareData,{
                title : encodeURIComponent(getArticleProperty("articleTitle")),
                title_gbk : getArticleProperty("articleTitleGBK"),
                url : encodeURIComponent(getArticleProperty("articleUrl"))
            });
        },
        bindEvent:function(){
            var _this = this;
            $(".js-tyweibo").bind("click",function(){
                if(!__global.isOnline()){
                    TY.loginAction();
                    return;
                }

                var _id = 'bbs_share_t';
                var pop=new TY.ui.pop({
                    headTxt:"转发到天涯微博",
                    body:'<div id="'+_id+'" style="width:600px;height:166px;">正在加载...</div>',
                    isMod:true,
                    isShowButton:false  
                });
                (function(){
                    TY.loader('TY.ui.twitterPost',function(){
                            var dBox = $('#'+_id).html('');
                            window.twitterPost = new TY.ui.twitterPost({
                                el:$('#'+_id),
                                isCross:true,
                                type: "shareTweet",
                                from:"天涯来吧",
                                appId:"laiba",
                                successTxt: "转发成功",
                                oPostData:{
                                    "appBlock":getArticleProperty("groupId"),
                                    "postId":getArticleProperty("articleId"),
                                    "preUrl":getArticleProperty("articleUrl"),
                                    "preTitle":getArticleProperty("articleTitle"),
                                    "preUserName":getArticleProperty("writer"),
                                    "preUserId":getArticleProperty("idwriter"),
                                    "prePostTime":getArticleProperty("articleTime"),
                                    "sourceName":"天涯来吧",
                                    "sourceLink":"http://laiba.tianya.cn",
                                    "type":2
                                },
                                plugins:'friend,emotion',
                                twitterObj:'twitterPost',
                                callback: function(){
                                    window.twitterPost.remove();
                                    pop.remove();
                                }
                            });
                    });
                })();
            });
            
            $(".js-sinaweibo").bind("click",function(){
                window.open('http://service.weibo.com/share/share.php?url=' + _this.shareData.url + '&title=' + _this.shareData.title + '&content=utf-8&ralateUid=2140585607&appkey=482040646', 'sw', 'toolbar=0,status=0,resizable=1,width=440,height=430')
            });
            
            $(".js-qzone").bind("click",function(){
                window.open('http://sns.qzone.qq.com/cgi-bin/qzshare/cgi_qzshare_onekey?url=' + _this.shareData.url + '&title=' + _this.shareData.title + '&site=' + _this.shareData.site, 'qw', 'toolbar=0,status=0,resizable=1,width=600,height=480');
            });
            
            $(".js-qqweibo").bind("click",function(){
                window.open('http://share.v.t.qq.com/index.php?c=share&a=index&url=' + _this.shareData.url + '&assname=' + _this.shareData.site + '&title=' + _this.shareData.title, 'qw2', 'toolbar=0,status=0,resizable=1,width=600,height=480');
            });
            
            $(".js-renren").bind("click",function(){
                window.open('http://share.xiaonei.com/share/buttonshare.do?link=' + _this.shareData.url + '&title=' +  _this.shareData.title, 'rw', 'toolbar=0,status=0,resizable=1,width=600,height=400')
            });
            
            $(".js-tieba").bind("click",function(){
                window.open('http://tieba.baidu.com/f/commit/share/openShareApi?url=' + _this.shareData.url + '&title=' +  _this.shareData.title_gbk,'tw','toolbar=0,status=0,resizable=1,width=600,height=400')
            });
            
            $(".js-douban").bind("click",function(){
                window.open('http://www.douban.com/recommend/?url=' + _this.shareData.url + '&title=' +  _this.shareData.title,'dw','toolbar=0,resizable=1,scrollbars=yes,status=1,width=600,height=400');
            });
            
            $(".js-penyou").bind("click",function(){
                window.open('http://sns.qzone.qq.com/cgi-bin/qzshare/cgi_qzshare_onekey?to=pengyou&url=' + _this.shareData.url + '&title=' + _this.shareData.title + '&site=' + _this.shareData.site, 'qw', 'toolbar=0,status=0,resizable=1,width=600,height=480');
            });
        },
        init:function(){
            if (dMod.size()){
                dMod.html([
                    '<a href="javascript:void(0);" class="share-icos share-icos-1 js-tyweibo" title="分享到天涯微博">天涯微博</a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-2 js-sinaweibo" title="分享到新浪微博"></a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-4 js-qqweibo" title="分享到腾讯微博"></a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-3 js-qzone" title="分享到QQ空间"></a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-5 js-renren" title="分享到人人网"></a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-6 js-tieba" title="分享到百度贴吧"></a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-7 js-douban" title="分享到豆辨网"></a>',
                    '<a href="javascript:void(0);" class="share-icos share-icos-8 js-penyou" title="分享到腾讯朋友"></a>'
                ].join(''));
            }
            
            if (selMod.size()){
                $("body").append([
                    '<div id="f_shareBox">',
                        '<ul class="f-selbox" class="clearfix">',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-2 js-sinaweibo">新浪微博</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-4 js-qqweibo">腾讯微博</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-3 js-qzone">QQ空间</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-5 js-renren">人人网</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-6 js-tieba">百度贴吧</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-7 js-douban">豆辨网</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-8 js-penyou">腾讯朋友</a></li>',
                            '<li><a href="javascript:void(0);" class="share-icos share-icos-1 js-tyweibo">天涯微博</a></li>',
                        '</ul>',
                    '</div>'
                ].join(""));
                
                bindSelPosition({
                    parent : selMod,
                    box : $("#f_shareBox"),
                    top : 2,
                    left : -36
                });
            }
            
            this.getPageData();
            this.bindEvent();
        }
    }
    
    shareBox.init();
}

//获取帖子的数据
function getArticleProperty(property){
    var hiddenData = jQuery("#hiddenDataBox");
    return hiddenData.find("input[name='"+property+"']").val();
}

//分页跳转
function initPageForm(){
    jQuery(".pageForm").submit(function(e){
        e.preventDefault();
        var url = '',
            form = jQuery(this),
            val = form.find(".pagetxt").val(),
            maxPage = parseInt(form.attr("_maxPage"),10),
            spaceParam = form.attr("spaceParam");
        if(val && /^\d+$/.test(val) && val <= maxPage){
             url = "http://groups.tianya.cn/tribe/showArticle.jsp?groupId="+
                        getArticleProperty("groupId") + 
                        "&articleId=" + getArticleProperty("articleId") +
                        "&curPageNo=" + val;
             if(spaceParam){
                url += "&qy=" + spaceParam;
             }           
             document.location.href = url;
        }else{
            alert("请填写正确的页码.");
        }
        return false;
    });
    
    //对键盘左右键监听，主要针对帖子页的上页和下页
    //捕捉后模拟响应 .js-keyboard-prev   .js-keyboard-next
	jQuery(document).keydown(function(e){
	        var target  = jQuery(e.target);
	        var tag = target.prop('tagName');
	        if(tag === "INPUT" ||tag === "TEXTAREA"){//文本框中的左右键不做监听
	            return;
	        }
	        var which = e.which;
	        var href = null;
	        if(which === 37){
	            href = jQuery('.js-keyboard-prev').attr('href');
	        }
	        if(which === 39){
	            href = jQuery('.js-keyboard-next').attr('href');
	        }
	        if(href){
	            window.location.href = href;
	        }
	    });
}

// 回到顶部、底部按钮
function setFolatMenu($) {
    $('body').append([
        '<div id="flat_menu" class="bbs-flat-menu">',
           '<div class="scroll-btn"><a href="javascript:scroll(0, 0);" class="s-btn scroll-top-btn js-scroll-top-btn"></a><a href="#fabu_anchor" class="s-btn toreply-btn js-toreply-btn"></a></div>',
        '</div>'
    ].join(""));
    
    var dScrollTop = $('#flat_menu');
    var dDoc = $('#mainDiv');
    var nLeft = 0;
    var nWidowWidth = 0;
    var nDocWidth = 0;
    var dScrollTopWidth = 0;
    var bIE = $.browser.msie && $.browser.version === "6.0" ? true : false;
    var sPosition = bIE ? 'absolute' : 'fixed';
    
    var resize = function() {
        nWidowWidth = $(window).width();
        nDocWidth = dDoc.outerWidth();
        dScrollTopWidth = dScrollTop.outerWidth();
        dScrollTopHeight = dScrollTop.outerHeight();
        
        var nFooter = Math.max($(document).height() - dDoc.offset().top
                        - dDoc.outerHeight() - 30, 0);
        if (nWidowWidth > nDocWidth + dScrollTopWidth * 2) {
            dScrollTop.css({
                left : (nWidowWidth + nDocWidth) / 2,
                right : 'auto'
            });
        } else {
            dScrollTop.css({
                left : 'auto',
                right : 0
            });
        }
        if (bIE) {
            dScrollTop.css({
                top : $(document).scrollTop() + $(window).height()
                        - nFooter - dScrollTopHeight,
                bottom : 'auto',
                position : sPosition
            }).show();
        } else {
            dScrollTop.css({
                top : 'auto',
                //bottom : nFooter,
                position : sPosition
            }).show();
        }
    };
    
    $("a.js-toreply-btn").bind("click",replyToAuthor);

    var nTimeout = null;
    if (bIE) {
        $(window).bind("resize scroll", function(){
            dScrollTop.hide();
            clearTimeout(nTimeout);
            nTimeout = setTimeout(function(){
                resize();
            }, 300);
        });
    }
    else {
        $(window).bind("resize", function(){
            resize();
        });
    }
    
    resize();
}

// 登陆按钮
function initLoginBind(){
   jQuery(".loginBtn").click(function(){
        TY.loginAction();
        return false;
   });
   
}

function getVipCode(startype, stardesc, starurl) {
    // 认证
    var sStarHtml = '';
    switch (+startype) {
        case 1 :
            sStarHtml = '<em class="my-16 my-16-company" title="'
                    + (stardesc || '企业认证用户') + '"></em>';
            break;
        case 2 :
            sStarHtml = '<a class="my-16 my-16-star" title="'
                    + (stardesc ? '天涯牛人认证：' + stardesc : '天涯牛人认证')
                    + '" href="http://my.tianya.cn/#app=vuser" target="_blank"></a>';
            break;
        case 3 :
            sStarHtml = '<a class="my-16 my-16-mobile" title="手机认证用户" target="_blank" href="http://www.tianya.cn/mobile/identity"></a>';
            break;
        default :
            sStarHtml = '';
    }
    return sStarHtml;
}
//用户V图标认证
function checkVipStatus($) {
    var dDoms = $('.js-vip-check');
    if (dDoms.size() === 0) {
        return;
    }
    var oUser = {};
    var sUid = "";
    dDoms.each(function() {
                sUid = $(this).attr('uid');
                if (!isNaN(+sUid)) {
                    if (!oUser[sUid]) {
                        oUser[sUid] = [];
                    }
                    oUser[sUid].push($(this));
                }
            });
    var aUser = [];
    $.each(oUser, function(name, val) {
                aUser.push(name);
            });
    if (aUser.length === 0) {
        return;
    }
    var formatVip = function(oVip) {
        var type = 0;
        var desc = "";
        var url = "";
        if (oVip.mtype == 1) {
            type = 3;
        }
        if (oVip.vtype == 1) {
            type = 2;
        }
        if (oVip.btype == 1) {
            type = 1;
            desc = oVip.bd;
            url = oVip.burl;
        }
        if (oVip.type == 2) {
            type = 3;
        }
        if (oVip.type == 1) {
            type = 2;
        }
        if (oVip.type == 3) {
            type = 1;
        }
        return {
            type : type,
            desc : desc,
            url : url
        }

    };
    var addVip = function(aDoms, oVip) {
        oVip = formatVip(oVip);
        var sVip = getVipCode(oVip.type, oVip.desc, oVip.url);
        $.each(aDoms, function() {
            if (oVip.type == 3){
                return;
            }
            $(this).after(sVip);
        });
    };
    var url = "http://806.tianya.cn/adsp/user/getVIipUser.jsp?userid="
            + aUser.join(',');
    $.ajax({
        url : url,
        dataType : "jsonp",
        jsonp : "jsonpcallback",
        success : function(aRs) {
            if (!aRs || aRs.length === 0) {
                return;
            }
            var ui = "";
            var aDoms = [];
            $.each(aRs, function(i, oData) {
                ui = oData.ui || "";
                ui = oData.userId;// todo 806接口
                aDoms = oUser[ui] || [];
                addVip(aDoms, oData);
            });
        }
    });

}
function showMobileTip(){
    jQuery("span.showtipfromwap").html('<a href="/tribe/showArticle.jsp?groupId=4&articleId=8833177e0e02d6e10b24aafda2849be5" target=_blank><FONT SIZE="2" COLOR="blue"><U>本帖来自掌中天涯-部落 3g.tianya.cn/groups</U></FONT></a>');
}
//开始页面流程
jQuery(function(){
   
   initShareBox(jQuery);
   initPageForm();
   initCollectArticle();
   setFolatMenu(jQuery);

   initLoginBind();
   
   initReplyId();
   
   if(__global.isOnline()){
       initBuluoPost(); 
   }
   
   checkVipStatus(jQuery);
   showMobileTip();
});
