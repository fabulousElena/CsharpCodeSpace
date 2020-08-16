
$(function(){
		var oldDesc = '添加个性签名';
		describe_define = function(){
			var myDesc = $('#my_describe');
			var text = oldDesc = $.trim(myDesc.val());
			if(text !='添加个性签名') {
				myDesc.css({'background-position':'3px 1000px','padding-left':'2px'});
			} 
		};
		describe_define();
		
		$('#my_describe').live('focus',function(){
		var text = $.trim($(this).val());
		text = text == '添加个性签名'? '':text;
		$(this).val(text).css({'border-color':'#c7c7c7','background-color':'#fff','background-position':'3px 1000px','padding-left':'2px','cursor':'text'}); 
		$('#my_desc_tip').fadeIn();
		})
		
		$('#my_describe').live('keyup',function(event){
			if(event.keyCode=='13') {
				$('#my_describe').blur();
			}
		})
		
		$('#my_describe').live('blur',function(){
		var text = $.trim($(this).val());
		if(text == '') {
		$(this).val(' 添加个性签名').css({'border-color':'#f7f7f7','background-color':'#f7f7f7','background-position':'3px -443px','padding-left':'15px','cursor':'pointer'}); 
		} else {
		$(this).val(text).css({'border-color':'#f7f7f7','background-color':'#f7f7f7','cursor':'pointer'});
		}
		$('#my_desc_tip').hide();
		if(text == '' && oldDesc == '添加个性签名') {		//未添加
			return;
		} else if(text != '' && text == oldDesc){		//未修改
			return;
		} else if(text != '' && text != oldDesc){		//修改&&添加
			$.get(_domain_bbs + 'api.php',{act : 'changeSelfSign',uid : _user_id,signature : text}, function(data) {
				if (data['status'] != 203) {
					alert(data['data']);
					return false;
				}
			}, 'json');
			oldDesc = text;
		} else if(text == '' && oldDesc != '添加个性签名') {		//删除
			$.get(_domain_bbs + 'api.php',{act : 'changeSelfSign',uid : _user_id,signature : text}, function(data) {
				if (data['status'] != 203) {
					alert(data['data']);
					return false;
				}
			}, 'json');
			oldDesc = '添加个性签名';
		}
		})
	 
	//绑定回车登录
	 $('#reply_not_login :input ').bind('keyup', function(event){
		   if (event.keyCode=="13"){
		    //需要进行的处理程序
			   return reply_checklogin();
		   }
		});
	 
	//用户名与密码框背景
	 $('#reply_user_name').focus(function(){
		 $(this).css('background-position','200px -385px');	
	 });
	 $('#reply_user_name').blur(function(){
		 var a = $(this).val();
		 if(!a){
			 $(this).css('background-position','16px -385px');
		 }
	 });
	 $('#reply_password').focus(function(){
		 $(this).css('background-position','200px -385px');	
	 });
	 $('#reply_password').blur(function(){
		 var a = $(this).val();
		 if(!a){
			 $(this).css('background-position','16px -335px');
		 }
		 
	});
	 
		//-------------------------------------回复框iframe
		//可编辑化
		var frame = window.frames['reply_iframe'];
		var wind = frame.window;
		var doc = frame.document;
		var body = doc.body;
		if(window.ActiveXObject) {
			body.contentEditable = true;
			body.attachEvent('onpaste',function() {setTimeout(pasteFliter,1)});
			body.attachEvent('onkeyup',insertAt);
			body.attachEvent('onkeyup',createIERange);		//IE中记录当前光标位置
			body.attachEvent('onclick',createIERange);
			body.attachEvent('onkeyup',checkNum);
			body.attachEvent('onpaste',checkNum);
		} else {
			doc.designMode = 'on';
			body.addEventListener('paste',function() {setTimeout(pasteFliter,1)},false);
			body.addEventListener('keyup',insertAt,false);
			body.addEventListener('keyup',checkNum,false);
			body.addEventListener('paste',checkNum,false);
		}
		//添加iframe内部样式
		var i_style = doc.createElement('link');
		i_style.rel = 'stylesheet';
		i_style.href = 'http://www.paidai.com/styles/bbs/reply_iframe.css?v=050302';
		doc.getElementsByTagName('head')[0].appendChild(i_style);
		body.style.cssText = 'width:638px;';	//宽度写在样式表中会出现横向滚动条
		//IE中生成range（当前光标位置）
		function createIERange() {
			IERange = doc.selection.createRange();		//全局,供插入表情和@使用
		}
	//------------------------------------@功能相关
		//获取默认关注列表
//		var atDefaultList = '';
//		;(function(){
//			$.post('',{},function(data){
//				atDefaultList = data;
//				$('#at_list').append(atDefaultList);
//			});
//		}());
		/*-----------------------------------------------------@点击事件----------------------------------------------------*/	
		//点击@图标
		var atContainer = $('#at_container'),
			atInput = $('#at_input');
		$('#reply_at').click(function(){
			if(window.ActiveXObject) {		//for IE
				if(typeof IERange !== 'undefined') {
					frame.focus();
					IERange.pasteHTML('@');
					var left = IERange.offsetLeft,
						top = IERange.offsetTop - 2;
					top = top < -2 ? -2:top > 143 ? 143:top;
					atContainer.css({'left':left,'top':top}).show();
					atInput.focus();
				} else {		//未输入内容，直接@
					frame.focus();
					doc.selection.createRange().pasteHTML('@');
					atContainer.show();
				}
			} else {		//for FF
				frame.focus();
				doc.execCommand('insertHTML',false,'@<span id="at_pointer">|</span>');	//空标签在FF下无法插入>_<#
				var atPointer = doc.getElementById('at_pointer');
				var left = atPointer.offsetLeft,
					top = atPointer.offsetTop - 6 - body.scrollTop;
				top = top < -2 ? -2:top > 143 ? 143:top;
				atContainer.css({'left':left,'top':top}).show();
				atPointer.parentNode.removeChild(atPointer);
				atInput.focus();
			}
		})
		
		//@按键shift + 2
		function insertAt(e) {
			var keyNum = e.which || wind.event.keyCode;
			if(keyNum == 50 && (e.shiftKey || wind.event.shiftKey)) {
				if(window.ActiveXObject) {		//for IE
					var left = IERange.offsetLeft,
						top = IERange.offsetTop - 2;
					top = top < - 2 ? -2:top > 143 ? 143:top;
					setTimeout(function(){
						atContainer.css({'left':left,'top':top}).show();
						atInput.focus();
					},10);
				} else {		//for FF
					doc.execCommand('insertHTML',false,'<b id="at_pointer">|</b>');//此处无@ 
					var atPointer = doc.getElementById('at_pointer');
					var left = atPointer.offsetLeft + 2,
						top = atPointer.offsetTop - 6 - body.scrollTop;
					top = top < -2 ? -2:top > 143 ? 143:top;
					atContainer.css({'left':left,'top':top}).show();
					atPointer.parentNode.removeChild(atPointer);
					atInput.focus();
				}
			}	
		}

		//指向当前@人物
		$('#at_list li').live('hover',function(){
			$('#cur_p').removeAttr('id');
			$(this).attr('id','cur_p');
		});
		
		//点击@人名
		$('#at_list li').live('click',function(){
			var atPersonName = 	$(this).text();
			insertAtPerson(atPersonName);
			frame.focus();
		})
		//添加@人名
		function insertAtPerson(a) {
			if(window.ActiveXObject) {
				if(typeof IERange !== 'undefined') {
					IERange.select();
					IERange.pasteHTML(a + '&nbsp;');
				} else {
					frame.focus();
					body.innerHTML += a + '&nbsp;';
				}
			} else {
				doc.execCommand('insertHTML',false,a);
				doc.execCommand('insertHTML',false,'&nbsp;');
			}
			$('#at_input').val('');
//			$('#at_list').empty().append(atDefaultList);
			$('#at_container').hide();
			oldPersonName = '';
		}
		//监听输入与方向键
		var oldPersonName = '';
		$('#at_input').keyup(function(e) {
			var keyNum = e.keyCode || event.keyCode,
				personList = $('#at_list li'),
				currentPerson = $('#cur_p'),
				newPersonName = $('#at_input').val();
			var atLastWord = newPersonName.substr(newPersonName.length - 1);
			if(atLastWord === " ") {
				newPersonName = newPersonName.slice(0,newPersonName.length - 1);
				insertAtPerson(newPersonName);
				frame.focus();
			}
			if(newPersonName == oldPersonName) {
				switch(keyNum) {
					case 40:                //按了向下的键
						if(!currentPerson.next().length) {
							currentPerson.removeAttr('id');
							personList.first().attr('id','cur_p');
						} else {
							currentPerson.removeAttr('id').next().attr('id','cur_p');
						};
						break;
					case 38:                //按了向上的键
						if(!currentPerson.prev().length) {
							currentPerson.removeAttr('id');
							personList.last().attr('id','cur_p');
						} else {
							currentPerson.removeAttr('id').prev().attr('id','cur_p');
						};
						break;
					case 13:                //回车键
						var atPersonName = 	currentPerson.text();
						insertAtPerson(atPersonName);
						break;
				}
			} else {
				var sendAtQuery = setTimeout(function(){
					clearTimeout(sendAtQuery);
					$.post('',{},function(){
						oldPersonName = newPersonName;
					});
				},200);
			}
		});
		//隐藏@弹层
		$('#at_input').blur(function(){
			setTimeout(function(){
				$('#at_container').hide();
				if(typeof IERange !== 'undefined') {
					IERange.select();
				} else {
					frame.focus();
				}
			},200);
		})
		
		//过滤函数
		function pasteFliter(){
			body.innerHTML = filter(body.innerHTML);
			frame.focus();
			if(window.ActiveXObject) {
				IERange = doc.selection.createRange();
				IERange.moveStart("character",body.innerHTML.length); 
				IERange.select();
			}
		}

		function filter(content) {	
			return content.replace(/<xml>[\s\S]*?<\/xml>/gi,'').replace(/<\s*style[^>]*?>[^<]*?<\s*\/\s*style\s*>/gi,'').replace(/<\s*script[^>]*?>[\s\S]*?<\s*\/\s*script\s*>/gi,'').replace
			(/<\s*(h\d|div)[^>]*?>/gi,'<p>').replace(/<\s*\/\s*(h\d|div)[^>]*?>/gi,'</p>').replace(/<(?!img|br|\/?p)[^>]*?>/gi,'').replace
			(/\s(style|class|id|align|border)\s*=\s*(["'])[\s\S]*?\2/gi,'').replace(/<!--.*?-->/gi,'').replace(/<\s*p\s*><\s*\/\s*p\s*>/gi,'');	
		};
		
		
		//--------------------------------表情相关-------------------------------------------
		//切换弹层
		$('#reply_smile').click(function(){
			$('#layer_faces').toggle('fast');
		});
		//插入表情
		$('#layer_faces ul').click(function(e) {
			var clicked = $(e.target);
			if(clicked.is('i')) {
				var imgSrc = "http://static.epaidai.com/images/brow/" + clicked.parent().index() + ".gif";
				frame.focus();
				if(typeof currentRange !== 'undefined') {
					currentRange.pasteHTML('<img src="' + imgSrc + '"/>');
				} else {
					doc.execCommand('insertImage',false,imgSrc);
				}
				$('#layer_faces').toggle('fast');
			};
		});
		//点击X
		$('#layer_faces h3 img').click(function(){
			$('#layer_faces').toggle('fast');
		}); 
        var formauthcode = encodeURIComponent(getCookie('XForum_AuthCode'));
        var iid = encodeURIComponent(getCookie('XForum__pdiid'));
		//---------------------------------------------------swfUpload上传图片配置--------------
		swfu_init = function(){
		swfu = new SWFUpload({	//全局变量
			upload_url: "http://www.paidai.com/new_uploadfile.php?act=uploadfile",
			post_params : {"uid" :_user_id ,"uname" :_user_name,'authcode':formauthcode,'iid':iid},
			file_size_limit : "4 MB",
			file_types : "*.jpg;*.gif;*.png;*.bmp",
			file_post_name : "filedata",
			// Event Handler Settings 
			file_queue_error_handler : fileQueueError,
			file_dialog_complete_handler : fileDialogComplete,
			upload_error_handler : uploadError,
			upload_success_handler : uploadSuccess,
			upload_complete_handler : uploadComplete,	
			// Button settings
			button_image_url : "http://www.paidai.com/images/bbs/new/reply_img_btn.gif?v=050311",
			button_placeholder_id : "reply_img_btn",
			button_width: 40,
			button_height: 38,
			// Flash Settings
			flash_url : "http://www.paidai.com/images/bbs/swfupload.swf",
			debug: false
		});
		}
		//swfUpload相关函数
		function fileDialogComplete(numFilesSelected, numFilesQueued) { //选取完图片后开始上传
			if (numFilesQueued > 0) {
				this.startUpload();
			}
		}
		function uploadSuccess(file, serverData) { //上传成功后插入图片
            try {
			var obj = jQuery.parseJSON(serverData);
			if(!obj.error) {
				var srcval = obj.imgUrl,
				idval = obj.imgid,
				imagetag = '<img src='+srcval+' img_id='+idval+'  /><br/>&nbsp;';
				if(window.ActiveXObject){
					frame.focus();
					doc.selection.createRange().pasteHTML(imagetag);			
				}else{			
					doc.execCommand('insertHTML',false,imagetag);
					window.focus();
				}
			}else {
				alert(obj.error);
				return false;
			}
            } catch(e) {
                console.log(serverData);
            }
		}
		function uploadComplete(file) {		//一张图片上传完成
			if (this.getStats().files_queued > 0) {
				this.startUpload();
			}
		}
		function fileQueueError(file, errorCode, message) {	//加入上传队列出错
			switch (errorCode) {
			case SWFUpload.QUEUE_ERROR.ZERO_BYTE_FILE:
				alert('图片大小为零！');
				break;
			case SWFUpload.QUEUE_ERROR.FILE_EXCEEDS_SIZE_LIMIT:
				alert('图片大小限制为2M！');
				break;
			default:
				alert(message);
				break;
			}
		}
		function uploadError(file, errorCode, message) { 
			//上传过程出错
			if(errorCode == SWFUpload.UPLOAD_ERROR.UPLOAD_STOPPED){
		 		alert('上传已终止，请重试！');
			} else {
				alert(message);
			}
		}
		
		//点击提交按钮
		var reply_submit_status = 0;
		$('#reply_submit').click(function(){
			if(!_user_id) {
				$('#reply_log_note').html('亲，先登录哦！');
				return false;
			} 
			if(reply_submit_status == 1) {
				return false;
			}
			reply_submit_status = 1;
			var content = doc.body.innerHTML.replace(/(@\S{1,8})&nbsp;/gi,'$1 ').replace(/\s(width|height)\s*=\s*"[\s\S]*?"/gi,'').replace(/<\s*(h\d|div)[^>]*?>/gi,'<p>').replace(/<\s*\/\s*(h\d|div)[^>]*?>/gi,'</p>'),
				tid = $('#reply_iframe_topicid').val();
			if(content=='' ) {
				$('#reply_log_note').html('回复内容不少于3字符！');
				return false;
			}
			//2012-12-10 新添添加到腾讯微博
 			if($('#to_tx').attr('checked') == 'checked'){
                var s_title = $(".t_title").text();
                var strc = content.replace(/<.*?>/gi,'');
				var reply_con = '我在@paidai2010 对《'+ s_title + '》的新评论：'+ strc;
				var _appkey = encodeURI("801283809"),
					_assname = encodeURI("611962003");
				if(reply_con.length > 110){
					reply_con = reply_con.slice(0,110) + '...';
				}
				window.open("http://share.v.t.qq.com/index.php?c=share&a=index&url="+window.location +  "&appkey=" + _appkey + "&assname=" +_assname + "&title=" + encodeURI(reply_con) +" ","","width=628,height=416");
			}
			$.post(_domain_bbs + 'post.php?act=ajaxReply',{ tid:tid, content:content},function(data){
				
				if(data['status']==103) {
					//清空回复内容 + 锚点定位(最新回复)
					doc.body.innerHTML ='';
					$('#reply_log_note').html('');
					//添加回复列表的末尾
					$('#reply_list').append(data['data']);
					delayLoadImg();
					load_report_submit();
					reply_submit_status = 0;
				} else {
					$('#reply_log_note').html(data['tips']);
					reply_submit_status = 0;
					return false;
				}
			},'json');
			
			if(!$("#reply_content").is(":visible")){
				$("#reply_content").fadeIn();
                $("div.reply_more_box").fadeIn();
			}
		});	

		//回复框获得焦点
		//frame.focus();
		
		//回复按钮反色
		var replySubmitEnabled = false;
		function checkNum() {
			var a = $.trim(body.innerHTML.replace(/<br>/i,'').replace(/<p>(&nbsp;)*<\/p>/i,'').replace(/&nbsp;/gi,'').replace(/<\/?p>/gi,''));
			if(a.length >= 3 && !replySubmitEnabled){
				$('#reply_submit').css({'background':'#5f7a5b','color':'#fff'}).removeAttr('disabled');
				replySubmitEnabled = true;			
			} else if(a.length < 3 && replySubmitEnabled){
				$('#reply_submit').css({'background':'#f7f7f7','color':'#323232'}).attr('disabled','disabled');
				replySubmitEnabled = false;
			}
		}

		if(_user_id){
			swfu_init();
		}
});


//新版回复框的登录
var new_nologin_submit_total = 0;
reply_checklogin=function() {
	$('#reply_log_note').html('');
	if(new_nologin_submit_total>0) return false;
	var account = $('#reply_user_name').val(),
	passwd = $('#reply_password').val();
	if(!account || account=='用户名') {
		$('#error_tips').html('请填写用户名');
		return false;
	}
	if(!passwd || passwd=='密码') {
		$('#error_tips').html('请填写密码');
		return false;
	}
	$.ajax({
		url: _domain_default + 'user/api.php',
		data: {act: 'login', account: account, passwd: passwd},
		dataType: 'jsonp',
		jsonp: 'jsonp',
		jsonpCallback: 'new_nologin_check'
	});
	return false;
	
}

//新版验证登录
function new_nologin_check(data) {
	if(typeof(data)!='object' || new_nologin_submit_total>0) return false;
	if(data['status']==501) {
		if(data['code']==4 || data['code']==3) {
			$('#error_tips').html('用户名不存在');
		}
		return false;
	} else if(data['status']==201) {
		if(data['code']==2) {
			$('#error_tips').html('密码错误，请重新输入');;
			return false;
		} else if (data['code']==1) {
			new_nologin_submit_total++;
			_user_id = data['uid'];
			_user_name = data['uname'];
			swfu_init();
		if(data['sign']) {
			var login = '<div id="reply_logged_in">'+
				'<a href='+_domain_default+'userlogin.php?action=logout'+' id="reply_log_out">退出</a>'+
            	'<a href='+_domain_my+data['uid']+' target="_blank"><img src="http://www.paidai.com/uploadpath/avatars/'+data['avatar']+'"></a>'+
                '<a href='+_domain_my+data['uid']+' target="_blank" class="user_link">'+data['uname']+'</a>'+
                '<input type="text" id="my_describe" value="'+data['sign']+'" maxlength="15" />'+
                '<span id="my_desc_tip">15个字以内</span>'+
                '</div>';
		} else {
			var login = '<div id="reply_logged_in">'+
			'<a href='+_domain_default+'userlogin.php?action=logout'+' id="reply_log_out">退出</a>'+
        	'<a href='+_domain_my+data['uid']+' target="_blank"><img src="http://www.paidai.com/uploadpath/avatars/'+data['avatar']+'"></a>'+
            '<a href='+_domain_my+data['uid']+' target="_blank" class="user_link">'+data['uname']+'</a>'+
            '<input type="text" id="my_describe" value=" 添加个性签名" maxlength="15" />'+
            '<span id="my_desc_tip">15个字以内</span>'+
            '</div>';
		}
			$('#reply_not_login').remove();
			$(login).insertBefore('#reply_irame_border');
			 
			//修改用户签名   
			describe_define();
			return false;
		}
	}
	return false;
}


