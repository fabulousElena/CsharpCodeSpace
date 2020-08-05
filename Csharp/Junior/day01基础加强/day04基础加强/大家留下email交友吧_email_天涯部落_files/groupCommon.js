function height_bg() {
	var m2 = document.getElementById("mm2").offsetHeight;
	var m1 = document.getElementById("mm1").offsetHeight;
	if(m1<m2){
		document.getElementById("mm1").style.height = m2+ "px";
	}
}

function joinGroup(groupId){
	if(!__global.isOnline()){
		if(!!parent)
			parent.MenuUtil.login('请先登录',window.location.href,window.location.href);
		else
			MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		var url = "http://groups.tianya.cn/tribe/applyJoinIn.jsp?groupId="+groupId+"&keepThis=true&TB_iframe=true&height=158&width=300";
		if(!!parent)
			parent.tb_show("申请加入部落", url);
		else
			tb_show("申请加入部落", url);
	}
}

function inviteJoin(groupId,invitee){
	var url = "http://groups.tianya.cn/tribe/inviteJoinIn.jsp?groupId="+groupId+"&userName="+escape(invitee)+"&keepThis=true&TB_iframe=true&height=200&width=350";
	tb_show("邀请好友加入部落", url);
}

function showRequestQuit(groupId){
	if(confirm('确定退出该部落？')){
		var url="http://groups.tianya.cn/tribe/requestQuit.jsp?groupId="+groupId+"&keepThis=true&TB_iframe=true&height=200&width=350"
		tb_show("退出部落",url);
	}
}

function showCreateGroupForMyTianya(){
	var url = "http://groups.tianya.cn/createGroup.jsp?TB_iframe=true&height=452&width=422&keepThis=true";
	try{
		parent.tb_show("创建部落",url);
	}catch(e){
		tb_show("创建部落",url);
	}
}

function showInviteJoinForMyTianya(groupId){
	var url = "http://groups.tianya.cn/tribe/inviteJoinIn.jsp?groupId="+groupId+"&keepThis=true&TB_iframe=true&height=200&width=350";
	try{
		parent.tb_show("邀请好友加入部落",url);
	}catch(e){
		tb_show("邀请好友加入部落",url);
	}
}

function showRequestQuitForMyTianya(groupId){
	var url="http://groups.tianya.cn/tribe/requestQuit.jsp?groupId="+groupId+"&keepThis=true&TB_iframe=true&height=200&width=350";
	try{
		parent.tb_show("退出部落",url);
	}catch(e){
		tb_show("退出部落",url);
	}
}

function joinGroupForMyTianya(groupId){
	var url = "http://groups.tianya.cn/tribe/applyJoinIn.jsp?groupId="+groupId+"&keepThis=true&TB_iframe=true&height=158&width=300";
	try{
		parent.tb_show("申请加入部落", url);
	}catch(e){
		tb_show("申请加入部落", url);
	}
}

function createTianyaUserUrl(userName) {
	return "http://www.tianya.cn/n/" + userName;
}
function createGroupLink(groupId) {
	//return "http://groups.tianya.cn/tribe/singleGroupIndex.jsp?groupId=" + groupId;
	return "http://groups.tianya.cn/list-"+groupId+"-1.shtml";
}
function createGroupArticleLink(groupId, articleId) {
	return "http://groups.tianya.cn/tribe/showArticle.jsp?groupId=" + groupId + "&articleId=" + articleId;
}

function createGroupManageLink(groupId){
	if(!!idOfWriter && idOfWriter != 0)
		//return "/"+idOfWriter+"/laiba?app=bulomanage&groupId="+groupId;
		return "/group/manage?groupId="+groupId;
	else
		return "/#app=bulomanage&groupId="+groupId;
}

function createMyTianyaLink(frameUrl){
	return "http://www.tianya.cn"+frameUrl;
}

function createGroupLogoHtml(logoUrl, width, height, groupName, other) {
	var defaultUrl = "http://groups.tianya.cn/images/logo_s_s.jpg";
	logoUrl = jQuery.trim(logoUrl);
	if (logoUrl.length < 1) {
		logoUrl = defaultUrl;
	}
	var html = "<img width='" + width + "' height='" + height + "' src='" + logoUrl + "' title='" + groupName + "' ";
	if (other != null) {
		html = html + other;
	}
	if (logoUrl != defaultUrl) {
		html = html + " onerror='this.src=\"" + defaultUrl + "\";this.onerror=null;' ";
	}
	html = html + " />";
	return html;
}

function getGroupStateName(groupState){
	switch(groupState){
		case 0:
			return "注销";
		case 1:
			return "正常";
		case 2:
			return "未审核";
		case 3:
			return "推荐";
		case 4:
			return "审批不通过";
		default:
			return "";
	}
}

function getGroupPublicStateName(groupPublicState){
	switch(groupPublicState){
		case 0:
			return "不公开";
		case 1:
			return "半公开";
		case 2:
			return "公开";
		default:
			return "";
	}
}

function getGroupHistoryIconByType(type){
	switch (type) {
		case 1: return "/images/icon_new_a.gif";
		case 2: return "/images/icon_new_g_add.gif";
		case 3: return "/images/icon_pic.gif";
		case 4: return "/images/icon_new_g.gif";
		case 5: return "/images/icon_new_g.gif";
		case 6: return "/images/icon_fav.gif";
		default:
			break;
	}
	return "/images/icon_pic.gif";
}

function createGroup(){
	if(!__global.isOnline()){
		MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		//tb_show('创建部落', '/createGroup.jsp?TB_iframe=true&height=462&width=422&keepThis=true');
		tb_show('创建部落', '/createGroup.jsp?TB_iframe=true&height=122&width=422&keepThis=true');
		//tb_show('创建部落', '/createGroup_trans.jsp?TB_iframe=true&height=122&width=422&keepThis=true');
	}
}

function stopCompose(){
	if(!__global.isOnline()){
		MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		//tb_show('创建部落', '/createGroup.jsp?TB_iframe=true&height=462&width=422&keepThis=true');
		tb_show('停止发表', '/stopCompose.jsp?TB_iframe=true&height=122&width=422&keepThis=true');
		//tb_show('创建部落', '/createGroup_trans.jsp?TB_iframe=true&height=122&width=422&keepThis=true');
	}
}

function stopReply(){
	if(!__global.isOnline()){
		MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		//tb_show('创建部落', '/createGroup.jsp?TB_iframe=true&height=462&width=422&keepThis=true');
		tb_show('停止回复', '/stopReply.jsp?TB_iframe=true&height=122&width=422&keepThis=true');
		//tb_show('创建部落', '/createGroup_trans.jsp?TB_iframe=true&height=122&width=422&keepThis=true');
	}
}

/**
 * 20131021
 */
function ApplyTrans(groupId){
	if(!__global.isOnline()){
		MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		tb_show('申请迁移部落',
				'http://groups.tianya.cn/applyTrans.jsp?groupId='
				+ groupId
				+ '&keepThis=true&TB_iframe=true&height=112&width=322');
				//'applyTrans.jsp?groupId='+groupId+'&TB_iframe=true&height=162&width=322&keepThis=true');
	}
}

/**
 * 发送天涯消息
 * @param uesrId 用户编号
 */
function sendTyMesg(userId) {
	if(!__global.isOnline()){
		MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		tb_show('发短信息',
				'http://my.tianya.cn/i/pub/sendMessage.jsp?userId='
					+ userId
					+ '&keepThis=true&TB_iframe=true&height=240&width=370');
	}
}

/**
 * 加为好友
 * @param uesrId 用户编号
 */
function addFriend(userId) {
	if(!__global.isOnline()){
		MenuUtil.login('请先登录',window.location.href,window.location.href);
	}else{
		tb_show('加为好友',
				'http://my.tianya.cn/i/pub/addFriend.jsp?userId='
					+ userId
					+ '&keepThis=true&TB_iframe=true&height=160&width=300');
	}
}

/**
 * 字符串截取
 *
 * @param {} str 字符串
 * @param {} size 长度
 * @return {String} 截取后的字符串+"..."
 */
function trimWords(str, size)  {
    if (str == null || str == "" || str == undefined) {
            return "&nbsp;";
    }
    if (str.length  <= size) {
        return str;
    } else {
        str = str.substring(0, size) + "...";
        return str;
    }
}

    /**
     * 根据类型返回信息类型的样式
     *
     * @param type
     *            信息类型
     * @return
     */
function getArticleClassByType(type) {
    switch (type) {
		case 2:
		    return "face_red";
		case 3:
		    return "face_green";
		case 4:
		    return "face_black";
		default:
		    return "face_blue";
	}

}
/**全站名人手机认证Logo*/
function personalityMobileCertificate() {try {
	/**
	personalityMobileCertificate.isNum = function(theNum) {
      return /^[0-9]\d*$/.test(theNum);
    }

    String.prototype.trim = function () {
      return this.replace(/(^\s*)|(\s*$)/g, '');
    }

    var tables = document.getElementsByTagName("table");
    var tbl, spans, span, userid, ads_url;
    var users = new Object();
    var spanbuf = new Array();
    var use_array = new Array();
    var spname = "";

    // 针对部落部落
    for (var idx = 0; idx < tables.length; idx++) {
        tbl = tables[idx];
        spans = tbl.getElementsByTagName("span");

        if (spans.length != 0) {
            span = spans[0];
            userid = span.getAttribute("value");
            spname = span.getAttribute("name");

            if (userid != "" && userid != null && spname != "music_player") {

              userid = userid.trim();
              if (personalityMobileCertificate.isNum(userid)) {
	              users[userid] = 0;
	              spanbuf.push(span);
              }
            }
        }
    }

    var user_str = "";
    for (var prop in users) {
        if(personalityMobileCertificate.isNum(prop)) {
          use_array.push(prop);
          if (use_array.length == 100) {
            break;
          }
        }
    }
    if (use_array.length != 0) {
        user_str = use_array.join(",");
    }else{
    	return;
    }

    ads_url = "http://806.tianya.cn/adsp/user/getVIipUser.jsp?userid=" + user_str;
    jQuery(document).ready(function () {
        jQuery.ajax({
            url: ads_url,
            dataType: "jsonp",
            jsonp: "jsonpcallback",
            success: function (data) {
                jQuery.each(data, function (i, v) {
                    for (var idx = 0; idx < spanbuf.length; idx++) {
                        span = spanbuf[idx];
                        if (span.getAttribute("value") == v["userId"]) {

                            newImg = document.createElement("img");
                            newlnk = document.createElement("a");
                            newImg.border = "0";
                            newImg.align = "absmiddle";
                            if (v["type"] == 1) {
                              newImg.src = "http://static.tianyaui.com/img/static/2008/tygg/vs2.gif";
                              newlnk.title = "天涯牛人认证";
                              newlnk.href = "http://my.tianya.cn/" + v["userId"];
                            } else if(v["type"] == 2) {
                              newImg.src = "http://801.tianyaui.com/res/2010/1130/1291094730345.gif";
                              newlnk.href = "http://807.tianya.cn/count?t=EsHTQDHjb9uCrdbqZrng&backurl=http://passport.tianya.cn/portect?action=smsintro&from=successtiezitubiao";
                              newlnk.title = "手机认证用户";
                            } else if(v["type"] == 3) {
                              newImg.src = "http://static.tianyaui.com/img/static/2008/tygg/ent.gif";
                              newlnk.title = "企业认证用户";
                              newlnk.href = "http://my.tianya.cn/" + v["userId"];
                            }
                            newlnk.target = "_blank";
                            newImg.width = "16";
                            newImg.height = "16";
                            newlnk.appendChild(newImg);

                            span.appendChild(newlnk);
                            try { span.style.cssFloat = "none"; span.style.styleFloat = "none"; } catch (e) { }
                            span.style.display = "inline";

                        }
                    }
                });
            }
        });
    });
    */
} catch (e) {}}



function loginTiaya(msg,sucessUrl,failureUrl){

	if(window.self != window.top){
		var urlForQySpace = window.parent.location.href+"&action=compose";
		parent.MenuUtil.login(msg,urlForQySpace,urlForQySpace);
	}else{
		MenuUtil.login(msg,sucessUrl,failureUrl);
	}
}


function removeHTMLTag(str) {
    str = str.replace(/<\/?[^>]*>/g,''); //去除HTML tag
    str = str.replace(/[ | ]*\n/g,'\n'); //去除行尾空白
    //str = str.replace(/\n[\s| | ]*\r/g,'\n'); //去除多余空行
    str=str.replace(/&nbsp;/ig,'　');//去掉&nbsp;
    return str;
}

//意见反馈
(function() {
    var switcher = {
        targetUrl : '',
        //front表示首页
        pageFlag: '',
        init : function() {
            if (window.top == self) {

                if(this.detectBbs()){
                     jQuery(document).ready(function(){
                        switcher.initDom();
                        switcher.bindEvent();
                     });
                }
            }
        },

        bindEvent : function() {
            var _this = this;
            jQuery('.ty_tip_no_more').click(function(event) {
                if (typeof(clickPartLink) == "function"){
                    clickPartLink(event,'stat',"新版顶导航/返回旧版");
                }
            });

            jQuery('.yijianfankui').click(function(event) {
                if (typeof(clickPartLink) == "function"){
                    clickPartLink(event,'stat',"新版顶导航/意见反馈");
                }
            });


           if(window.screen.availWidth > 1024){
                jQuery('body.layout-1280').livequery(function() {
                    var pos = _this.getPosition();
                    if(!pos){return;}
                    if(pos.left){
                       jQuery('.ty_tip_box').css("left",pos.left+"px").show();
                    }
                });
                jQuery('body.layout-1024').livequery(function() {
                    var pos = _this.getPosition();
                    if(!pos){return;}
                    if(pos.left){
                       jQuery('.ty_tip_box').css("left",pos.left+"px").show();
                    }
                });
                jQuery(window).resize(function(){
                    var pos = _this.getPosition();
                    if(!pos){return;}
                    if(pos.left){
                       jQuery('.ty_tip_box').css("left",pos.left+"px").show();
                    }
                });
            }
        },
        getPosition: function(){
            var obj = {};
            var mainDiv = null,
                offset = null, posTop = 0, posLeft = 0, left = 0;
            if(this.pageFlag === 'front'){
                mainDiv = jQuery('#mm2');
                obj.top = 70;
            }else{
                mainDiv = jQuery('#doc');
		        if(mainDiv.size() === 0){
		             mainDiv =  jQuery('#mainDiv');
		        }
                obj.top = 60;
            }

            if(mainDiv.size() == 0){
                return;
            }
            offset = mainDiv.offset();
//            posTop = offset.top;
//            obj.top = 60;//posTop;

            if(window.screen.availWidth > 1024){
                posLeft = offset.left + parseInt(mainDiv.width(),10) + 1;
                obj.left = posLeft;// + 'px';
            }else{
                obj.right = '0';
                obj.left = null;
            }
            return obj;
        },
        initDom : function() {

            var pos = this.getPosition();
            if(!pos){
                return;
            }
            var temp = pos.left ? ("left:" + pos.left): ("right:" + pos.right);
            temp += "px;";
            var _html = '<div class="ty_tip_box" style="'
                    + 'position:absolute;width:25px;top:' + pos.top + 'px;'
                    + temp
                    + '">'
                    + '<a class="yijianfankui" title="谈谈新版感受和问题(无需登录)" href="http://bbs.tianya.cn/list.jsp?item=797&sub=4"></a>'
                    + "</div>";
            jQuery(_html).appendTo(document.body).children('.yijianfankui').css({
                background: 'url("http://static.tianyaui.com/global/lite/images/ico.png") no-repeat scroll 0 -3030px transparent',
			    display: 'block',
			    height: '86px',
			    overflow: 'hidden',
			    width: '25px'
            });

        },
        detectBbs : function() {
            var i = 0, pathname = document.location.pathname,
                rs = null, regs = [
                    /\/$/,

                    /\/tribe\/member\.jsp/i,
                    /\/tribe\/pictureLib\.jsp/i,
                    /\/list-\d+-\d+\.shtml/i,
                    /\/tribe\/singleGroupIndex\.jsp/i,

                    /\/tribe\/showArticle\.jsp/i,
                    /\/post-\d+-\w+-\d+\.shtml/i
                    ];

            while (regs[i]) {
                if (regs[i].test(pathname)){
                    break;
                }
                i++;
            }
            if(i === 0){
                this.pageFlag = "front";
            }
            if (i === regs.length) {
                return false;
            }else{
                return true;
            }
        }
    };
    switcher.init();
})();





