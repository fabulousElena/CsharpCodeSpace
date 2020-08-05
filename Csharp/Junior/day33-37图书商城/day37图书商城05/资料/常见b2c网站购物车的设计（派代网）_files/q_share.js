	window.onload = function(){
		var test = document.getElementById('topic_content');
		var link_to_tx = document.getElementById('link_to_tx');
        var scrollX = document.documentElement.scrollLeft || document.body.scrollLeft;
        var scrollY = document.documentElement.scrollTop || document.body.scrollTop;
		var select_text;

		window.onscroll= function(){
			scrollX = document.documentElement.scrollLeft || document.body.scrollLeft;
			scrollY = document.documentElement.scrollTop || document.body.scrollTop;
		}
		
		function selectText(){
			if(document.selection){  //IE
				return document.selection.createRange().text;  //zhi
			}else{     
				return window.getSelection().toString();	//window.getSelection()返回的是对象，因为下面要检测选中文字的长度，所以要将其变成字符串
			}	
		}
		
		test.onmouseup = function(ev){
			//alert(selectText());
			if(selectText().length > 10){
				if( selectText().length > 120){
					select_text = selectText().slice(0,120)+'...';
				} else {
                    select_text = selectText();
                }
				var ev = ev || window.event;
//有关事件的相关属性，像ev.clientX等属性必须直接写在该事件函数中，而不能写在事件函数的子函数中，即ev.clientX;不能在setTimeout函数中使用，需要先在onmouseup中赋值给一个变量，再在setTimeout函数中使用。
				var left = ev.clientX + scrollX;  
				var top = ev.clientY + scrollY - 10;
				setTimeout(function(){
					link_to_tx.style.display = 'block';
					link_to_tx.style.left = left + 'px';
					link_to_tx.style.top = top + 'px';							
				},100);							
			}else{
				link_to_tx.style.display = 'none';
			}
		}
		
		test.onclick = function(ev){    //必须有这句话，否则链接图片永远不出现
			var ev = ev || window.event;
			ev.cancelBubble = true;
		}
		
		link_to_tx.onclick = function(ev){	
            // var s_title = $(".t_title").text();
            var s_title = $(".t_title").text();
            var _appkey = encodeURI("801283809"),
                _assname = encodeURI("611962003");
			var ev = ev || window.event;
			ev.cancelBubble = true;
			window.open("http://share.v.t.qq.com/index.php?c=share&a=index&url="+window.location + "&appkey=" + _appkey + "&assname=" +_assname + "&title=我在看@派代网官方 觉得《" + s_title + "》的这句：" + select_text + " 不错！");			
		}
		
		document.onclick = function(){
			link_to_tx.style.display = 'none';
		}
	}