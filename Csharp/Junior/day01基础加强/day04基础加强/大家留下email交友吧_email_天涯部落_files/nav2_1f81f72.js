TY.namespace("ui"),TY.loadedModule("TY.ui.nav"),TY.ui.nav=function($){function getDomain(){var t=document.domain,a=t.split("."),n=a.length;return t=n>=2?a[n-2]+"."+a[n-1]:"tianya.cn"}function format(t){var a=arguments,n=2==a.length&&"object"==typeof a[1]?a[1]:a;return t.replace(/\{([\d\w]+)\}/g,function(t,a){return void 0!=n[a]?n[a].toString():t})}function getTpl(t,a){var n=[];if(t&&a)for(var e=0,i=a.length;i>e;e++)n.push(format(t,a[e]));return n.join("")}function htmlFilter(t,a){var n=["&","&amp;","<","&lt;",">","&gt;"," ","&nbsp;",'"',"&quot;","'","&#039;","\\r","<br>","\\n","<br>","/","&#047;","\\\\","&#092;"];a&&n.reverse();for(var e=0,i=t;e<n.length;e+=2)i=i.replace(new RegExp(n[e],"g"),n[1+e]);return i}function getData(t,a,n,e,i){$.ajax({url:t,data:a||{},cache:i||!1,dataType:e||"script",scriptCharset:"utf-8",success:function(){n&&$.isFunction(n)&&n()}})}function commonSet(t,a){for(var n=a.el,e=a.num||!1,i=a.tpl||liTpl,s=a.map||{},o=a.stat||"",l=0,r=t.length;r>l;l++){for(var c in s)t[l][c]=t[l][s[c]];t[l].stat=o,t[l].title2||(t[l].title2=e?t[l].title.subStringCn(e,!0):t[l].title)}n.html(getTpl(i,t))}function commonLoad(t){var a=t.data["var"];getData(t.url,t.data,function(){if("undefined"!=typeof window[a]){var n=window[a].data?window[a].data:window[a];$.isArray(n)&&!n.length&&n.push({title:t.emptyMsg||"暂无记录",link:"javascript:;"}),t.set?t.set(n,t):commonSet(n,t)}},"script",t.cache||!1)}function setIframe(t){var a='<iframe frameborder="0" style="left:0px;width:100%;height:100%;top:0px;position:absolute;z-index: -1;filter: Alpha(Opacity=0);" class="js-iframe"></iframe>';isIE6&&t.prepend(a)}function floatDiv(t,a,n,e,i){function s(e){u=!0,setTimeout(function(){u&&(c&&(clearTimeout(c),c=null),a.show(),e&&e(),t.addClass(n))},p/2)}function o(){u=!1,c=setTimeout(function(){u||(a.hide(),t.removeClass(n))},p)}function l(t,a){t.mouseover(function(){s(a)}).mouseout(function(){o()})}function r(t){t.click(function(){"none"==a.css("display")?(e(),s()):o()})}var c=null,p=300,u=!1,n=n||"";l(a),"click"==i?r(t):l(t,e),setIframe(a)}function scroll(t){function a(){r&&i.animate({top:-1*n*c++ +"px"},"normal","linear",function(){return c>=o?(i.css({top:"0px"}),c=0,void 0):void 0}),setTimeout(function(){a()},l)}var n,e=t.className||"ty-bt-scroll-list",i=TY(t.wrapSelector||"#bottom_nav ul.art-lite"),s=TY(t.itemsSelector||"#bottom_nav ul.art-lite li"),o=s.size(),l=t.time||6e3,r=!0,c=0;i.addClass(e).append(TY(s.get(0)).clone()),n=s.eq(0).height(),i.hover(function(){r=!1},function(){r=!0}),a()}function initTopNavDom(t){if(0!=Conf.showTopNav){var a=t&&t.doc?t.doc(Conf):['<div id="top_nav_wrap" style="display:none;'+(950==Conf.topNavWidth||980==Conf.topNavWidth?"width:"+Conf.topNavWidth+"px;":"")+'">','<div class="clearfix" id="top_nav">','<div class="top-nav-logo">','<a _tystat="新版顶导航/Logo" href="http://focus.tianya.cn/"></a>',"</div>",'<div class="top-nav-main clearfix">','<div class="top-nav-menu clearfix">','<div class="top-nav-fl clearfix">','<ul class="top-nav-menu-list clearfix">','<li class="top-nav-menu-li top-nav-menu-li-first"><a _tystat="新版顶导航/论坛" _checklocation="1" appstr="bbs" class="top-nav-main-menu" href="http://bbs.tianya.cn/">论坛</a>',"</li>",'<li class="top-nav-menu-li"><a _tystat="新版顶导航/分社区/聚焦" _checklocation="1" appstr="focus" class="top-nav-main-menu" href="http://focus.tianya.cn/">聚焦</a>',"</li>",'<li class="top-nav-menu-li"><a _tystat="新版顶导航/部落" class="top-nav-main-menu" href="http://bbs.tianya.cn/index_self.jsp">部落</a>',"</li>",'<li class="top-nav-menu-li"><a _tystat="新版顶导航/博客" _checklocation="1" appstr="blog" class="top-nav-main-menu" href="http://blog.tianya.cn/">博客</a>',"</li>",'<li class="top-nav-menu-li"><a _tystat="新版顶导航/问答" _checklocation="1" appstr="wenda" class="top-nav-main-menu" href="http://wenda.tianya.cn/">问答</a>',"</li>",'<!-- <li class="top-nav-menu-li"><a _tystat="新版顶导航/天涯客" href="http://travel.tianya.cn/" class="top-nav-main-menu" appstr="travel" _checklocation="1">天涯客</a></li>-->','<li class="top-nav-menu-li"><a _tystat="新版顶导航/文学" _checklocation="1" appstr="ebook" class="top-nav-main-menu" href="http://ebook.tianya.cn">文学</a>',"</li>",'<li class="top-nav-menu-li"><a href="http://show.tianya.cn/" class="top-nav-main-menu" _tystat="新版顶导航/天涯秀场" appstr="show" _checklocation="1">天涯秀场</a></li>','<li class="top-nav-menu-li">','<div class="more-view" id="top_nav_menu_more_view">','<ul class="link-list clearfix">','<li><a href="http://travel.tianya.cn/" _tystat="新版顶导航/天涯客">天涯客旅游</a></li>','<li><a _tystat="新版顶导航/游戏" href="http://game.tianya.cn/">游戏</a>',"</li>",'<!--<li><a _tystat="新版顶导航/品牌" href="http://pinpai.tianya.cn/">品牌</a>',"</li>-->",'<!-- <li><a _tystat="新版顶导航/应用" href="http://apps.tianya.cn/">应用</a>',"</li>-->",'<li><a _tystat="新版顶导航/购物街" href="http://mall.tianya.cn/">购物街</a>',"</li>",'<li class="li-border-btm"><a _tystat="新版顶导航/天涯商家" href="http://shop.tianya.cn">天涯商家</a>',"</li>",'<li><a _tystat="新版顶导航/充值中心" href="http://pay.tianya.cn/">充值中心</a>',"</li>",'<li><a _tystat="新版顶导航/社区商店" href="http://apps.tianya.cn/gift">社区商店</a>',"</li>",'<li><a _tystat="新版顶导航/服务" href="http://service.tianya.cn/index.do">社区服务</a>',"</li>","</ul>","</div>",'<span class="top-nav-main-menu" id="top_nav_menu_more">更多<i class="top-ico-main-arrow"></i>',"</span>","</li>","</ul>","</div>",'<div class="top-nav-fr top-search" id="top_search">','<div class="clearfix">','<form method="get" action="http://search.tianya.cn/bbs" id="top_search_form">','<input type="submit" value="" class="top-search-submit" id="top_search_submit_btn">','<input type="text" autocomplete="off" value="" class="top-search-key off" name="q" id="top_search_key">',"</form>","</div>",'<div class="top-search-type" id="top_search_type">',"<ul>",'<li id="search_zone_list"></li>','<li><a href="javascript:void(0);" id="search-text">含有<strong>?</strong>的内容&gt;&gt;</a>',"</li>",'<li><a href="javascript:void(0);" id="search-user">名为<strong>?</strong>的人&gt;&gt;</a>',"</li>",'<li class="clearfix">','<dl class="forum-list">',"<dt>含有","<strong>?</strong>的版块&gt;&gt;</dt>","</dl>","</li>",'<li><a href="javascript:void(0);" id="search-tab">去<strong>?</strong>的标签&gt;&gt;</a>',"</li>","</ul>","</div>","</div>",'<div class="top-nav-fr" id="top_user_menu">','<ul class="top-nav-menu-list clearfix"></ul>',"</div>","</div>","</div>","</div>","</div>"].join(""),n=$("#top_nav").size()>0?!0:!1;n||(Conf.topNavBanner===!0&&(a='<div id="top_nav_banner">'+a+"</div>"),Conf.flex===!0&&(a='<div id="top_nav_flex">'+a+"</div>"),$(Conf.app_id).prepend(a))}$(Conf.app_id).prepend('<div id="top_nav_test"></div>'),(1==Conf.topNavFromHtml||0!=Conf.showTopNav)&&initTopNavEvent(t)}function loginInfo(t){var a=[],n='<li class="top-nav-menu-li"><a href="'+qingUrl+'mobile/" class="white top-nav-user-menu" _checklocation="1" appstr="mobile" _tystat="新版顶导航/手机"><i class="top-ico-user-phone"></i></a></li>';t&&t.userInfo?t.userInfo():1==isOnline?(a=['<li class="top-nav-menu-li top-nav-menu-li-first"><a class="top-nav-user-menu" href="'+qingUrl+userId+'" appstr="mypage"  _checklocation="1" _tystat="新版顶导航/用户名">'+userName+"</a></li>",isIe6OrMobile?'<li class="top-nav-menu-li"><a href="http://www.tianya.cn/message/sys"" target="_blank" class="top-nav-user-menu nav-msg" id="top_nav_msg_t" title="系统通知"><span class="top-ico-user-sys"></span><i><strong></strong></i></a></li> <li class="top-nav-menu-li"><a href="http://www.tianya.cn/message/user" target="_blank" class="top-nav-user-menu nav-msg" id="top_nav_msg_user" title="站内短信"><span class="top-ico-user-msg"></span><i><strong></strong></i></a></li>':"",n,'<li class="top-nav-menu-li top-nav-menu-li-other"><span id="top_nav_set" class="top-nav-user-menu"><i class="top-ico-user-setting"></i></span></li>'],$("#top_nav #top_user_menu .top-nav-menu-list").append(a.join("")),a=['<div id="top_nav_set_view" class="more-view">','<ul class="link-list clearfix">','<li><a href="'+qingUrl+'set/" _tystat="新版顶导航/设置">设置</a></li>','<li><a href="'+qingUrl+userId+'/profile" _tystat="新版顶导航/个人主页">个人主页</a></li>','<li><a href="'+qingUrl+'user/" _tystat="新版顶导航/关系中心">关系中心</a></li>','<li><a id="js_relogin" href="javascript:void(0);" _tystat="新版顶导航/更换账号">更换账号</a></li>','<li><a href="http://passport.tianya.cn/logout?returnURL='+encodeURIComponent(qingUrl+"user/logout?returnURl="+encodeURIComponent(document.location.href))+'&fowardFlag=y" _tystat="新版顶导航/退出">退出</a></li>',"</ul>","</div>"].join(""),$("#top_nav_set").before(a),floatDiv($("#top_nav_set"),$("#top_nav_set_view"),"on",null,"mouseover")):(a=['<li class="top-nav-menu-li  top-nav-menu-li-first"><a class="top-nav-user-menu" id="js_login" href="javascript:void(0);" rel="nofollow" _tystat="新版顶导航/登录">登录</a></li>','<li class="top-nav-menu-li"><a class="top-nav-user-menu" href="http://passport.tianya.cn/register/default.jsp?sourceURL='+encodeURIComponent(window.location.href)+'" target="_blank" rel="nofollow" _tystat="新版顶导航/注册">注册</a></li>',n],$("#top_nav #top_user_menu .top-nav-menu-list").append(a.join(""))),$("#js_login,#js_relogin").bind("click",function(){return isMobile?(location="http://passport.tianya.cn/login.jsp?fowardURL="+encodeURIComponent(window.location.href),void 0):(TY.loginAction(),void 0)})}function PlaceHolder(t,a){function n(n){var e=t.val();n?e==a&&t.val(""):""==e&&t.val(a)}t.focus(function(){n(!0)}).blur(function(){n(!1)}),t.val(a),this.getVal=function(){return val=$.trim(t.val()),val==a?"":val},this.empty=function(){t.val(a)}}function initTopSearchEvent(){function t(){p=-1,u=l.find("a").size(),l.find("a").removeClass(r)}function a(t,a){var n,e=l.find(".forum-list"),i=[],s=t.rows;e.find("dd").remove();for(var o=0,r=s.length;r>o&&rowNum>o;o++)n=s[o].split("/"),i.push('<dd><a href="'+bbsUrl+"list-"+n[0]+'-1.shtml">'+n[1].toLowerCase().replace(a,"<strong>"+a+"</strong>")+"</a></dd>"),n=null;e.append(i.join(""))}function n(n,e){e=e||rowNum;var s={url:bbsUrl+"api",data:{method:"bbs.ice.itemSearch","var":"forumArr","params.key":n,"params.all":!1,"params.pageSize":e,"params.pageNum":1},set:function(e){a(e,n),i(n),t()}};commonLoad(s)}function e(t){c=t,t=t.subStringCn(12,!0),l.find("strong").html(htmlFilter(t)),t=encodeURIComponent(t),$("#search-text").attr("href",resultUrl+searchTypes[searchType][1]+"?q="+t),$("#search-user").attr("href",resultUrl+"user?q="+t),$("#search-tab").attr("href",bbsUrl+"tag/"+t)}function i(t){for(var a,n=d,e=[],i=$("#search_zone_list"),s=0,o=n.length;o>s;s++){a=n[s];for(var l=0,r=a.length;r>l;l++)if(t==a[l]){e.push('  <dt><a href="'+a[1]+'"><strong>'+a[0]+"</strong>&gt;&gt;</a></dt>");break}}e.length?i.html("<dt>"+e.join("")+"</dt>"):i.html("")}var s=$("#top_search_form"),o=$("#top_search_key"),l=($("#top_search_submit_btn"),$("#top_search_type ul")),r="curr",c="",p=-1,u=-1,m=o.attr("_value")||"搜帖、找人、搜版块";iptObj=new PlaceHolder(o,m),rowNum=8,resultUrl="http://search.tianya.cn/",searchType=0,o.bind("keyup focus",function(a){var i,o=a.which;if(13===o)-1==p?s.trigger("submit"):(location.href=l.find("a").eq(p).attr("href"),l.hide(),t());else if(38===o||40===o){var m=38===o?-1:1,d=p;p+=m,p%=u,l.find("a").eq(d).removeClass(r).end().eq(p).addClass(r)}else i=iptObj.getVal(),""==i?l.hide():i==c?(l.show(),l.parent().show()):(e(i),l.show(),n(i),l.parent().show())}),s.bind("submit",function(){return str=iptObj.getVal(),""==str?(input.val("").focus(),!1):-1!=p?!1:void 0}),l.hide(),floatDiv(s,l.parent());var d=[["天涯聚焦","http://focus.tianya.cn","聚焦","聚","焦","jujiao","jujia","juji","juj","jj"],["天涯民生","http://news.tianya.cn","民生","民","生","minsheng","minsh","mins","ms"],["天涯文学","http://cul.tianya.cn","文学","文","学","wenxue","wenx","wx"],["天涯旅游","http://travel.tianya.cn","旅游","旅","游","lvyou","ly"],["天涯财经","http://biz.tianya.cn","财经","财","经","caijing","caij","cj"],["天涯汽车","http://auto.tianya.cn","汽车","汽","车","qiche","qich","qic","qc"],["天涯IT","http://it.tianya.cn","IT数码","IT","数码","数","码","it","shuma","shum","shm","sm"],["天涯时尚","http://fashion.tianya.cn","时尚","时","尚","shishang","shish","shis","shsh","shs","ss"],["天涯情感","http://emo.tianya.cn","情感","情","感","qinggan","qingg","qg"],["天涯娱乐","http://ent.tianya.cn","娱乐","娱","乐","yule","yul","yl"],["天涯视频","http://video.tianya.cn","视频","视","频","shipin","ship","shp","sp"],["天涯体育","http://sports.tianya.cn","体育","体","育","tiyu","tiy","ty"],["天涯图片","http://pp.tianya.cn","图片","图","片","tupian","tup","tp"],["天涯新知","http://xinzhi.tianya.cn","新知","新","知","xinzhi","xinzh","xinz","xzh","xz"],["天涯亲子","http://baby.tianya.cn","亲子","亲","子","qinzi","qinz","qz"],["天涯舆情","http://yuqing.tianya.cn","舆情","舆","情","yuqing","yuq","yq"],["天涯公益","http://gongyi.tianya.cn","公益","公","益","gongyi","gongy","gy"],["天涯星工场","http://star.tianya.cn","星工场","工场","星","xinggongchang","xgc"],["天涯传媒","http://media.tianya.cn","传媒","传","媒","chuanmei","chuanm","chm","cm"],["海南在线","http://www.hainan.net","海南在线","海南在","海南","在线","海","南","在","线","hainan","hain","hn","hi"],["天涯广东","http://gd.tianya.cn","广东","广","东","guangdong","guangd","gd"],["天涯上海","http://sh.tianya.cn","上海","上","海","shanghai","shangh","shh","sh"],["天涯北京","http://bj.tianya.cn","北京","北","京","beijing","beij","bj"],["天涯天津","http://tj.tianya.cn","天津","天","津","tianjin","tianj","tj"],["天涯重庆","http://cq.tianya.cn","重庆","重","庆","chongqing","chongq","chq","cq"],["天涯成都","http://cd.tianya.cn","成都","成","都","chengdu","chengd","chd","cd"],["天涯西安","http://xian.tianya.cn","西安","西","安","xian","xia","xa"],["天涯湖南","http://hunan.tianya.cn","湖南","湖","南","hunan","hun","hn"],["天涯深圳","http://sz.tianya.cn","深圳","深","圳","shenzhen","shenzh","shenz","shzh","shz","sz"],["天涯广西","http://gx.tianya.cn","广西","广","西","guangxi","guangx","gx"],["天涯山东","http://sd.tianya.cn","山东","山","东","shandong","shand","shd","sd"],["天涯江苏","http://js.tianya.cn","江苏","江","苏","jiangsu","jiangs","jians","js"],["天涯福建","http://fj.tianya.cn","福建","福","建","fujian","fuj","fj"],["天涯海外","http://abroad.tianya.cn","海外","海","外","haiwai","haiw","hw","abroad"],["中山大学校友社区","http://sysu.tianya.cn","zhongshandaxue","zhongda","中大","中山大学","中大校友","zhongshan","中山","孙中山","中山医","sysu"]]}function checkLocation(){function t(t,a){a>s&&(s=a,l.removeClass(o),t.addClass(o))}var a="http://"+location.hostname,n=location.href,e=Conf.app_str,i="",s=0,o=Conf.sel_class,l=$("#top_nav .top-nav-menu-list a");l.each(function(s,o){o=$(o),i=o.attr("href"),0==a.indexOf(i)&&t(o,1),e&&-1!=e.indexOf(o.attr("appstr"))&&t(o,2),n==i&&t(o,3)}),"http://blog.tianya.cn"==a&&(searchType=1,$("a#search-text").html("含有<strong>?</strong>的"+searchTypes[searchType][0]+"&gt;&gt;"),$("a#search-user").html("名为<strong>?</strong>的"+searchTypes[searchType][2]+"&gt;&gt;"))}function initTopNavEvent(t){loginInfo(t),checkLocation(),floatDiv($("#top_nav_menu_more"),$("#top_nav_menu_more_view"),"on",null,"mouseover"),initTopSearchEvent(),$("a[_tystat]",this.top_id).live("click",function(t){"function"==typeof clickPartLink&&clickPartLink(t,"stat",$(this).attr("_tystat"))}),t&&t.event&&t.event()}function initBottomNavDom(t){var a=isOnline?['<div id="bottom_username_view" class="more-view " style="display:none;">','<div class="bottom_username_view_wrap">','<div class="bottom_username_subnav clearfix">',"<ul>",'<li class="li-first">','<dl class="clearfix">','<dt><a href="'+qingUrl+userId+'">我的首页</a></dt>','<dd><a href="'+bbsUrl+'index_self.jsp" target="_blank">我的部落</a></dd>','<dd><a href="'+qingUrl+userId+'/blog" target="_blank">我的博客</a></dd>','<dd><a href="'+qingUrl+'t/post" target="_blank">我的随记</a></dd>',"</dl>","</li>","<li>",'<dl class="js-biz-data clearfix" id="biz_data" style="display:block;">','<dd><a href="http://bbs.tianya.cn/my_block.jsp" target="_blank">我的版块<span class="my-block"></span></a></dd>','<dd><a href="http://bbs.tianya.cn/my_compose_list.jsp" target="_blank">我的主帖<span class="my-compose"></span></a></dd>','<dd><a href="http://bbs.tianya.cn/my_reply_list.jsp" target="_blank">我的回帖<span class="my-reply"></span></a></dd>','<dd><a href="http://bbs.tianya.cn/my_collect.jsp" target="_blank">收藏更新<span class="my-collect"></span></a></dd>','<dd><a href="http://bbs.tianya.cn/view_art.jsp" target="_blank">我的浏览记录<span class="my-view"></span></a></dd>',"</dl>","</li>","</ul>","</div>","</div>","</div>"].join(""):"",n=['<div id="bottom_trace_view" class="more-view">','<ul class="link-list clearfix" id="bottom_trace_ul">','<li class="logoing"><img src="http://static.tianyaui.com/global/bbs/web/static/images/loading1.gif"></li>',"</ul>","</div>"].join(""),e=['<div id="bottom_nav_wrap" class="'+(t?t+"-bottom-nav":"")+'" style="display:;"><div class="bottom-nav-wrap"><div class="bottom-nav-bg"><div id="bottom_nav">','<div class="bottom-bg">','<ul class="ul-nav">','<li class="li-border-r li-user-name">'+a+'<span id="bottom_username" class="b-username login" biz-data="null" js-data="null">我的天涯</span></li>','<li class="li-border" id="bottom_diy_1">'+n+'<span id="bottom_trace" class="white" js-data="null"><span class="bottom-ico-bg bottom-ico-bg-3 login">足迹</span></span></li>','<li class="li-border-l"><span class="placeholder"></span></li>','<li class="art-view" id="bottom_diy_2"><ul class="art-lite ty-bt-scroll-list"></ul></li>','<li class="f-r li-border-l"><a href="javascript:scroll(0,0);" class="bottom-scroll-top" ></a></li>','<li class="f-r li-border"><a href="http://www.tianya.cn/message/sys" target="_blank" class="white white-r nav-msg login" id="bottom_msg_t" title="系统通知"><span class="bottom-ico-bg bottom-ico-bg-8"></span><i><strong></strong></i></a><a href="http://www.tianya.cn/message/user" target="_blank" class="white nav-msg" id="bottom_msg_user" title="站内短信"><span class="bottom-ico-bg bottom-ico-bg-9"></span><i><strong></strong></i></a></li>','<li class="f-r li-border-r"><a href="http://static.tianya.cn/city/cityJump.html" class="white myCityName" _tystat="新版底导航/城市">'+(userCity||"")+"</a></li>","</ul>","</div>","</div></div></div>"].join("");$("body").append(e),setWidth()}function setWidth(){function t(){$(window).width()>1255?(n.css({width:1255}),a.removeClass("bottom-small")):(n.css({width:1e3}),a.addClass("bottom-small"))}var a=$("#bottom_nav_wrap .bottom-nav-wrap"),n=$("#bottom_nav");$(window).bind("resize",t),t()}function MyTy(){function t(t){return t=parseInt(t||0,10),t>99?"99+":t}function a(){function a(){pub.myMsg.getMsg("amC",function(a){n.html("("+t(a)+")")})}if(!i){i=!0,getData("http://bbs.tianya.cn/api?method=bbs.ice.getUserInfo&var=g_bbsNums",{},function(){if("undefined"!=typeof g_bbsNums&&1==g_bbsNums.success&&g_bbsNums.data&&g_bbsNums.data.rows){var a=g_bbsNums.data.rows[0];e.find(".my-compose").html("("+t(a.compose_count)+")"),e.find(".my-reply").html("("+t(a.reply_count)+")")}});var n=e.find(".my-collect");a(),setInterval(function(){a()},6e4),n.parent().click(function(){pub.myMsg.delMsg("amC",!0),n.html("")}),getData("http://www.tianya.cn/api/tw?method=userBlock.ice.getUserBlock&params.blockState=0&var=g_blockNums",{},function(){if("undefined"!=typeof g_blockNums&&1==g_blockNums.success&&g_blockNums.data){var a=g_blockNums.data;e.find(".my-block").html("("+t(a.total)+")")}})}}var n=$("#bottom_username"),e=$("#biz_data"),i=!1;isOnline&&floatDiv(n,$("#bottom_username_view"),"b-username-over",function(){a()}),n.click(function(){return isOnline?(window.location=qingUrl+userId,void 0):(TY.loginAction(),void 0)})}function MyMsg(){function getCookie(){var msg=__global.getCookie(cookieName);if(!msg)return null;if(-1!==msg.indexOf(ch)){for(var arr=msg.split(ch),obj={},i=0,l=msgMap.length;l>i;i++)obj[msgMap[i][0]]=+arr[i]||0;return obj}try{return eval(msg)}catch(e){return null}}function setCookie(t){for(var a=[(new Date).getTime(),t.uId||__global.getUserId()],n=2,e=msgMap.length;e>n;n++)a.push(t[msgMap[n][0]]||0);__global.setCookieNoEscape(cookieName,a.join(ch),1,"/",domain,!1)}function showMsg(t,a,e){var i=isIe6OrMobile?"top_nav":"bottom",s=$("#"+i+e),o=s.find("i"),l=s.find("strong"),r="ons";n=parseInt(t[a],10),n&&(n=n>99?"99+":n,l.html(n),o.css({display:"inline"}),s.addClass(r)),s.unbind("click").click(function(){return t[a]&&(s.removeClass(r),o.css({display:"none"}),delMsg(t,a)),!0})}function delMsg(t,a,n){if("t"==a){for(var e=2,i=msgMap.length;i>e;e++)if(1==msgMap[e][2]){var s=t[msgMap[e][0]];t[msgMap[e][0]]=n&&n>0&&s>=n?s-n:0}}else t[a]=0;return setCookie(t),showMsg(t,"t","_msg_t"),showMsg(t,"uC","_msg_user"),t}function setMsg(t){var a,n={};n.tS=(new Date).getTime(),n.uId=t.uId||__global.getUserId();for(var e=2,i=msgMap.length;i>e;e++)a=msgMap[e],n[a[0]]=parseInt(t[a[1]]||0,10),a[2]&&(n.t+=parseInt(t[a[1]]||0,10));historyCookie=getCookie(),setCookie(n),showMsg(n,"t","_msg_t"),showMsg(n,"uC","_msg_user"),checkNewMsg(historyCookie,n)}function getMsg(t){getData(url,{},function(){var a=window[msgObj];"undefined"!=typeof a&&a.success&&a.data&&(setMsg(a.data),t&&t())})}function checkNewMsg(t,a){function n(){$.browser.msie?$("body").append('<bgsound id="newNsgSound" src="http://static.tianyaui.com/global/bbs/web/static/sound/tianyamsg.mp3" loop="0" autostart="true">'):$("body").append('<embed id="newNsgSound" src="http://static.tianyaui.com/global/bbs/web/static/sound/tianyamsg.swf" hidden="true" width="50" height="50" loop="false" autostart="true">')}var e=!1;t&&a&&parseInt(a.uC,10)>parseInt(t.uC,10)?e=!0:!t&&a&&a.uC>0&&(e=!0),e&&($.isReady?n():$(document).ready(n))}function updateMsg(){var t=(new Date).getTime(),a=getCookie();a&&a.uId==userId&&t<parseInt(a.tS,10)+loopTime?(showMsg(a,"t","_msg_t"),showMsg(a,"uC","_msg_user"),daShang.newHint(a.dsC)):getMsg(),setTimeout(function(){updateMsg()},loopTime)}function resetMsgItemData(t,a,n){var e={ALL:"messagecount.ice.clrarntfcount",fC:"messagecount.ice.updatefan",ryC:"messagecount.ice.updatereply",seC:"messagecount.ice.updateshare",rtC:"messagecount.ice.updaterequest",uC:"messagecount.ice.updateusercount",ssC:"messagecount.ice.updatesyscount",amC:"messagecount.ice.updateatme",aC:"messagecount.ice.updateapprovecount",dsC:"messagecount.ice.updatedashangcount",wlC:"messagecount.ice.updateweiluncount"};if("undefined"==typeof e[t])return!1;var i,s=getCookie();if(!s)return!1;if(i=s,"ALL"==t){if(!(i.t>0))return!1;i.t=i.fC=i.ryC=i.seC=i.rtC=i.ssC=i.aC=i.wlC=0,$.getScript(qingUrl+"api/tw?"+$.param({"var":"delmsgResult",method:e.ALL}),function(){n&&n()})}else{if(!(i[t]>0))return!1;i[t]=a&&a>0&&a<=i[t]?i[t]-a:0,$.getScript(qingUrl+"api/tw?"+$.param({"var":"r_upData",method:e[t],"params.count":i[t]}),function(){n&&n()})}return setCookie(i),showMsg(i,"t","_msg_t"),showMsg(i,"uC","_msg_user"),!0}if(!isOnline)return $("#bottom_msg_t ,#bottom_msg_user").click(function(){return TY.loginAction(),!1}),void 0;var cookieName="ty_msg",ch="_",historyCookie=null,msgObj="msgObj",msgMap=[["tS","tS",0],["uId","userId",0],["t","t",1],["fC","fanCount",1],["ryC","replyCount",1],["seC","shareCount",1],["rtC","requestCount",1],["uC","userCount",0],["ssC","sysCount",1],["amC","atMeCount",0],["aC","approveCount",1],["dsC","daShanfCount",0],["wlC","weilunCount",1]],loopTime=6e4,url="http://www.tianya.cn/api/tw?var=msgObj&method=messagecount.ice.select&params.userId="+userId;updateMsg();var wait=1;this.getMsg=function(t,a){var n=getCookie();return n&&"undefined"!=typeof n[t]?(a&&a(n[t]),n[t]):(wait--&&arguments.callee(t,a),!1)},this.delMsg=function(t,a,n,e){a?resetMsgItemData(t,n,e):(obj=getCookie(),delMsg(obj,t,n))}}function myTrace(t){var a=$("#bottom_trace"),n=$("#bottom_trace_view"),e=$("#bottom_trace_ul");t.set=t.set?t.set:commonSet,t.el=e,t.num=30,floatDiv(a,n,"on",function(){return isOnline?(t.load?t.load(t.set):commonLoad(t),void 0):(TY.loginAction(),void 0)},"click"),a.click(function(){return isOnline?void 0:(TY.loginAction(),void 0)})}function commonEvent(){MyTy(),showADV(),isMobile||daShang.init()}function showADV(){var t=new Date,a=t<new Date(2015,2,5,11,59)&&t>new Date(2015,1,18,0,0)?!0:!1;a&&$("#bottom_nav .ul-nav").append('<li class="f-r border-adv" id="border-adv"><a href="http://bbs.tianya.cn/post-lookout-389941-1.shtml" target="_blank" ></a></li>')}function initNav(){function t(){var t=n.height();t>0?($("#top_nav_wrap").show(),n.hide()):e--&&setTimeout(arguments.callee,50)}var a=pub[Conf.app_str]&&pub[Conf.app_str].initTop;"hainan"==Conf.app_str&&(Conf.showTopNav=!0),initTopNavDom(a),Conf.showBottomNav&&!isIe6OrMobile&&(initBottomNavDom(Conf.app_str),$("#bottom_nav_wrap").show(),pub[Conf.app_str]?pub[Conf.app_str].initBottom():pub["default"].initBottom(),pub.myMsg=new MyMsg),commonEvent();var n=$("#top_nav_test"),e=200;t()}var pub={},isOnline=__global.isOnline(),userId=isOnline&&__global.getUserId()||null,userName=isOnline&&__global.getUserName()||null,userCity=isOnline&&__global.getUserCityName()||null,liTpl='<li><a href="{link}" title="{title}" target="_blank" _tystat="新版底导航/{stat}">{title2}</a></li>',qingUrl="http://www.tianya.cn/",bbsUrl="http://bbs.tianya.cn/",blogUrl="http://blog.tianya.cn/",Conf={showBottomNav:!0,app_str:"bbs",app_id:"body",sel_class:" on "},searchTypes=[["内容","bbs","人"],["博文","blog","博主"]],isIE6=$.browser.msie&&6==$.browser.version?!0:!1,isMobile=TY.mobile.isMobile(),isIe6OrMobile=isIE6||isMobile,domain=getDomain();return pub.myTrace=myTrace,pub.getData=getData,pub.commonLoad=commonLoad,pub.commonSet=commonSet,pub.scroll=scroll,pub.getTpl=getTpl,pub.floatDiv=floatDiv,pub.initScreen=function(){},pub.initNavData=function(t){pub.myMsg.delMsg(t,!0)},pub.init=function(t){$.extend(Conf,t),isIE6?$("body").ready(function(){initNav()}):initNav()},pub}(TY);var daShang={loaded:!1,tryMax:30,tryNum:0,alone:!1,init:function(){var t=this;setTimeout(function(){TY.ajax({url:"http://static.tianyaui.com/gamify/broadcast/js/core.jsonp",dataType:"script",type:"GET",scriptCharset:"utf-8",cache:!0,success:function(){t.loaded=!0}})},15)},newHint:function(t){if(!TY.mobile.isMobile())if(this.loaded){if(window.TYGamify&&window.TYGamify.message&&t>0){var a=jQuery(document),n=a.data("dsc"),e=!1;n?t>+n&&(e=!0):e=!0,e&&(a.data("dsc",t),window.TYGamify.message("DS",t))}}else if(this.tryNum<this.tryMax){var i=arguments,s=this;setTimeout(function(){i.callee.apply(s,i)},500),this.tryNum++}}};TY.ui.nav["default"]=function(t){function a(t){try{var a=t.uname1+" 送给 "+t.uname2+"<span class='yellow'>"+t.pc+"</span>"+t.pu+"“"+t.pn+"”（"+t.shang+"红钻）";return'<li><a href="'+t.al+'" target="_blank" _tystat="新版底导航/YY动态">'+a+"</a>"+" &gt;&gt; "+"</li>"}catch(n){}}function n(t){var a,n,e,i=18;return a=t.an.replace(/[《|》]/g,""),a=a.getCNlen()>3*i?a.subStringCn(3*i)+"...":a,n=t.uname1+" 给 "+t.uname2+" 打赏了%%"+(t.pc||t.shang)+(t.pc?t.pu+t.pn:"赏金"),e=3*i-n.getCNlen(),a=a.getCNlen()>e?a.subStringCn(e)+"...":a,n=n.replace(/打赏了(%%)(\d*)(\S*)/,function(a,n,e,i){var s="打赏了<span class='yellow'>"+e+"</span>",o=(t.pid+1e3+"").substr(1);return str2="赏金"!=i?"<span class='daoju'>"+i+"<img src='http://static.tianyaui.com/global/dashang/images/propIcon/s/"+o+".png'  width='16' height='16'/></span>":i,s+str2}),'<li><a href="http://shang.tianya.cn" target="_blank" _tystat="新版底导航/打赏动态">'+n+"</a>"+" &gt;&gt; "+(t.al&&t.an?'<a href="'+t.al+'" target="_blank" title="'+t.an+'">《'+a+"》</a>":"")+"</li>"}function e(){if(m--,!m){for(var e,i=l.concat(o),s=[],c=0,p=i.length;p>c;c++)e=i[c],"yy"==e.from?s.push(a(e)):s.push(n(e));var u=['<a href="http://shang.tianya.cn/jsp/v2/mygiftpkg.html" target="_blank" title="打赏礼包" _tystat="新版底导航/打赏礼包" class="ty-bt-ds-icon ty-bt-dslb-icon"></a>','<ul class="art-lite">',s.join(""),"</ul>"].join("");t("#bottom_diy_2").html(u),setTimeout(function(){r.scroll({className:"",wrapSelector:"#bottom_diy_2 .art-lite",itemsSelector:"#bottom_diy_2 .art-lite li"})},0)}}function i(){function a(t){for(var a,n="serverName",e="-",i=0,s=t.length;s>i;i++)a=t[i][n].replace(/\—/g,e).split(e),t[i][n]=a[0]}function n(t){l.el=c,l.url="http://game.tianya.cn/api/call.do?method=game.server.gameUserLogin",l.data={"var":"gameUserLogin",pageSize:10},l.map={title:"gameName",link:"serverLink"},l.stat="我的游戏",l.set=function(n){var i=n.items||[];i.length?(a(i),r.commonSet(i,l),e("热门推荐"),t&&c.prepend("<li><h3>"+t+"</h3></li>"),c.show()):e()},r.commonLoad(l)}function e(t){l.el=o,l.url="http://game.tianya.cn/api/call.do?method=game.home.recommendGameList ",l.data={"var":"recommendGameList",pageSize:4},l.map=null,l.stat="推荐游戏",l.set=function(n){var e=n.list||[];e.length&&(a(e),r.commonSet(e,l),t&&o.prepend("<li><h3>"+t+"</h3></li>"))},r.commonLoad(l)}var i=t("#bottom_trace"),s=t("#bottom_trace_view"),o=t("#bottom_trace_ul"),l={};s.append('<ul id="bottom_trace_ul2" class="link-list clearfix" style="display:none;"></ul>');var c=t("#bottom_trace_ul2");l.el=o,l.num=10,l.tpl='<li><a href="{link}" title="{title}" target="_blank" _tystat="新版底导航/{stat}">{title2} <span>{serverName}</span></a></li>',t("#bottom_diy_1").addClass("bottom_game"),t("#bottom_trace_view").css({width:"152px"}),__global.isOnline()?t("#bottom_trace span").html("我的游戏"):t("#bottom_trace span").html("推荐游戏");var p=!1;r.floatDiv(i,s,"on",function(){p||(p=!0,__global.isOnline()?n("最近玩过"):e())},"mouseover"),i.click(function(){window.location="http://game.tianya.cn"})}function s(){r.commonLoad(d),r.commonLoad(h),i()}var o,l,r=TY.ui.nav,c={},p=new Date,u=p.getDate()+""+p.getHours(),m=2,d={url:"http://static.tianyaui.com/global/data/nav/dashang.tianya.cn/yyMovement.js?v="+u,cache:!0,data:{"var":"g_nav_yy_list"},set:function(t){l=t,e()}},h={url:"http://static.tianyaui.com/global/data/nav/dashang.tianya.cn/shangMovement.js?v="+u,cache:!0,data:{"var":"g_nav_shang_list"},set:function(t){o=t,e()}};return c.initBottom=s,c}(TY),TY.ui.nav.ebook=function(t){function a(){var a={url:"http://app.3g.tianya.cn/webservice/web/lastread.jsp",data:{"var":"ebookReadList"},stat:"读书/最近阅读",emptyMsg:"您暂无阅读作品的记录"};t("#bottom_trace span").html("最近阅读"),s.myTrace(a)}function n(){t("#bottom_diy_1").append('<div class="update-wrap"><ul id="ebook_update_ul"></ul></div>');var a=t("#ebook_update_ul"),n={el:a,url:"http://app.3g.tianya.cn/webservice/web/lastread_r.jsp",data:{"var":"updateList"},stat:"读书/更新列表",set:function(t){for(var a=0,e=t.length;e>a;a++)t[a].title2="《"+t[a].title.subStringCn(24,!0)+"》","1"==t[a].updflag&&(t[a].title2="<span>"+t[a].title2+" 更新了！</span>");s.commonSet(t,n),s.scroll({className:"update-li",wrapSelector:"#ebook_update_ul",itemsSelector:"#ebook_update_ul li"})}};s.commonLoad(n)}function e(){var a=t("#bottom_diy_2 .art-lite"),n=30,e={el:a,url:"http://book.tianya.cn/book3g/hudong/bookhudongtopjson.jsp?bookid=-1000&topno=20",stat:"读书/催更列表",data:{"var":"activeList"},set:function(t){for(var e=0,i='<li><img src="http://static.tianyaui.com/global/ebook/web/static/images/activeIcon/{img}.png" width="16" height="16"/><a href="http://www.tianya.cn/{idwriter}">{strwriter}</a> 给<a href="/book/{bookid}.aspx" title="{booktitle}" target="_blank">《{booktitle2}》</a> {content}</li>',o=0,l=t.length;l>o;o++)e=(t[o].xfCategory+100+"").substr(1),t[o].booktitle2=n?t[o].booktitle.subStringCn(n,!0):t[o].booktitle,t[o].img=e;a.html(s.getTpl(i,t)),s.scroll({className:"",wrapSelector:"#bottom_diy_2 .art-lite",itemsSelector:"#bottom_diy_2 .art-lite li"})}};s.commonLoad(e)}function i(){a(),n(),e()}var s=TY.ui.nav,o={};return o.initBottom=i,o}(TY),TY.ui.nav.hainan=function(t){var a={},n={doc:function(t){return['<div style="'+(950==t.topNavWidth||980==t.topNavWidth?"width:"+t.topNavWidth+"px;":"")+'" id="top_nav_hainan">','<div style="" class="clearfix" id="top_nav">','<div class="top-nav-logo">','<a _tystat="新版顶导航/Logo" target="_blank" href="http://www.tianya.cn/"></a>',"</div>",'<div class="top-nav-main clearfix">','<div class="top-nav-menu clearfix">','<div class="top-nav-fl clearfix">','<ul class="top-nav-menu-list clearfix">','<li class="top-nav-menu-li top-nav-menu-li-first"><a id="homepage" _tystat="新版顶导航/设为首页" class="top-nav-main-menu" href="javascript:"><span class="top-ico-user-home"></span>设为首页</a></li>','<li class="top-nav-menu-li top-nav-menu-li-bbs"><a _tystat="新版顶导航/论坛" _checklocation="1" appstr="bbs" class="top-nav-main-menu" target="_blank" href="http://bbs.tianya.cn/">论坛</a></li>','<li class="top-nav-menu-li"><a _tystat="新版顶导航/分社区/聚焦" _checklocation="1" appstr="focus" class="top-nav-main-menu" target="_blank" href="http://focus.tianya.cn/">聚焦</a></li>','<li class="top-nav-menu-li"><a _tystat="新版顶导航/部落" class="top-nav-main-menu" target="_blank" href="http://bbs.tianya.cn/index_self.jsp">部落</a></li>','<li class="top-nav-menu-li"><a _tystat="新版顶导航/博客" _checklocation="1" appstr="blog" class="top-nav-main-menu" target="_blank" href="http://blog.tianya.cn/">博客</a></li>','<li class="top-nav-menu-li"><a _tystat="新版顶导航/问答" _checklocation="1" appstr="wenda" class="top-nav-main-menu" target="_blank" href="http://wenda.tianya.cn/">问答</a></li>','<li class="top-nav-menu-li"><a _tystat="新版顶导航/读书" _checklocation="1" appstr="ebook" class="top-nav-main-menu" target="_blank" href="http://ebook.tianya.cn">读书</a></li>','<li class="top-nav-menu-li"><a _tystat="新版顶导航/邮箱" _checklocation="1" appstr="hnmail" class="top-nav-main-menu" target="_blank" href="http://mail.tianya.cn/home/hn/index.jsp">邮箱</a></li>',"</ul>","</div>",'<div class="top-nav-fr" id="top_user_menu">','<ul class="top-nav-menu-list clearfix">',"</ul>","</div>","</div>","</div>","</div>","</div>"].join("")
},userInfo:function(){var a=__global.isOnline()?'<li class="top-nav-menu-li top-nav-menu-li-first"><a class="top-nav-user-menu" href="http://www.tianya.cn/'+__global.getUserId()+'" target="_blank" appstr="mypage"  _checklocation="1" _tystat="新版顶导航/用户名">'+__global.getUserName()+"</a></li>"+'<li class="top-nav-menu-li"><a href="http://www.tianya.cn/message/sys"" target="_blank" class="top-nav-user-menu nav-msg" id="bottom_msg_t" title="系统通知"><span class="top-ico-user-sys"></span><i><strong></strong></i></a></li> <li class="top-nav-menu-li"><a href="http://www.tianya.cn/message/user" target="_blank" class="top-nav-user-menu nav-msg" id="bottom_msg_user" title="站内短信"><span class="top-ico-user-msg"></span><i><strong></strong></i></a></li>':'<li class="top-nav-menu-li  top-nav-menu-li-first"><a class="top-nav-user-menu" id="js_login" href="javascript:void(0);" rel="nofollow" _tystat="新版顶导航/登录">登录</a></li><li class="top-nav-menu-li"><a class="top-nav-user-menu" href="http://passport.tianya.cn/register/default.jsp?sourceURL='+encodeURIComponent(window.location.href)+'" target="_blank" rel="nofollow" _tystat="新版顶导航/注册">注册</a></li>';t("#top_user_menu .top-nav-menu-list").html(a)},event:function(){t("#homepage").bind("click",function(){if(document.all)document.body.style.behavior="url(#default#homepage)",document.body.setHomePage("http://www.hainan.net/");else if(window.sidebar){if(window.netscape)try{netscape.security.PrivilegeManager.enablePrivilege("UniversalXPConnect")}catch(t){alert("该操作被浏览器拒绝，如果想启用该功能，请在地址栏内输入 about:config,\n然后将项 signed.applets.codebase_principal_support 值该为true")}var a=Components.classes["@mozilla.org/preferences-service;1"].getService(Components.interfaces.nsIPrefBranch);a.setCharPref("browser.startup.homepage","http://www.hainan.net/")}else alert("您可以试下Ctrl+D，收藏本页。")})}};return a.initTop=n,a}(TY);