/**
 * 内容中标签显示处理JS
 *
 * 需要定义以下JS变量
 *
 *      urls_tag_mng                tag relation 处理链接
 *      tag_relation_obj_id         tag relation 对象ID
 *      tag_relation_type           tag relation 类型（1：主题，2：资讯，3：资料……）
 *
 * @author ccy@paidai.com
 * @since 2012-03-15
 *
 */
$(document).ready(function(){
    //修改原有标签z—index
    var tags_z_index = 998;
    $('.mytags li').each(function(){
        $(this).attr('style','z-index:' + tags_z_index);
        tags_z_index--;
    })
    //点击修改按钮    
    var tag_modify_flag = false;
    var delIco=('<a href="javascript:void(0);" class="del_ico"></a>');                    //定义删除按钮
    $("#change_tag").click(function(){
        $(".mytags").css("width","375px").find("li").append(delIco);
        $("#change_note").hide();
        $("#add_tag").fadeIn("nomal");
        $("#add_tag_text").bind('focus',textFocus).bind('keyup',textKeyUp);
        // 记录编辑次数
        $.getJSON(urls_tag_mng+'?act=ajax04&msg=ok&format=json&tid='+tag_relation_obj_id+'&type='+tag_relation_type+'&jsoncallback=?', function(data){ });
        $(".new_tag").attr('style','background:url(http://www.paidai.com/images/bbs/topic/new_tag_bg.gif) no-repeat right 120px;'); //点击修改按钮，隐藏新标签背景图片add@20120323by-rxq
        tag_modify_flag = true;
    });

    //定义冒泡删除标签事件
    $(".mytags").click(function(obj){
        var ico = $(obj.target);

        if(ico.attr("class")=="del_ico"){
            var id = ico.prev().attr('oid');
            var tag_uid = ico.prev().attr('uid');
            
            if(id) {
                $.getJSON(urls_tag_mng+'?act=ajax01&msg=ok&format=json&id='+id+'&oid='+tag_relation_obj_id+'&type='+tag_relation_type+'&tag_uid='+tag_uid+'&jsoncallback=?', function(data){
                    if(data.error == 1 || data.error == 2) {
                        _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;">' + data.content + '</div>', {modal:true} );
                        setTimeout( function(){ _boxy.hide(); }, 2000);
                    } else {
                        ico.parent().hide();
                    }
                });
            }
        };
    });

    //定义输入框获得焦点事件
    function textFocus(){
        if ($(this).val()!=''){

            var inputHelper=$("#input_helper");
            inputHelper.show();
            inputHelper.unbind('click',clickAdd).bind('click',clickAdd);   //绑定点击添加标签事件（避免多次绑定）
            inputHelper.find("ul").empty().append('<li><a href="javascript:void(0);" style="color:#000;display:inline-block;height:25px;padding:0 5px;text-decoration:none;background:#transparent;">添加 <span style="font-weight:bold; color:#000;background:transparent;padding:0;">'+$("#add_tag_text").val()+'</span> 标签</a></li>');
            /*--------------------  添加相关标签项   --------------------------*/
            inputHelper.find("ul").append(tag_list);

            /*--------------------  添加相关标签项   --------------------------*/
            inputHelper.find("ul li").bind('hover',relatTagsHover).first().next().addClass("current_tag");

        };
    };

    //定义输入框keyup事件
    var tag_list = null;
    var _old_k = null;
    function textKeyUp(e){
        var _keyword = $(this).val();
        _keyword = $.trim(_keyword);

        if (_keyword==''){
            $("#input_helper ul").empty();
            $("#input_helper").hide();                         //为空则隐藏（按backspace删除键）
        }else{
            if(_keyword == _old_k) {
                checkKey(e);            //判断按键
            }else{
                var inputHelper=$("#input_helper");
                inputHelper.find("ul").empty();
                inputHelper.hide();
                tag_list = null;
                $.getJSON(urls_tag_mng+'?act=ajax02&msg=ok&format=json&k='+_keyword+'&jsoncallback=?', function(data){
                    if(data.error == 0) {
                        tag_list = data.content;
                    }
                    inputHelper.show();
                    inputHelper.unbind('click',clickAdd).bind('click',clickAdd);
                    inputHelper.find("ul").empty();
                    inputHelper.find("ul").append('<li><a href="javascript:void(0);" style="color:#000;display:inline-block;height:25px;padding:0 5px;text-decoration:none;background:#transparent;">添加 <span style="font-weight:bold; color:#000;background:transparent;padding:0;">'+$("#add_tag_text").val()+'</span> 标签</a></li>');
                    /*--------------------  添加相关标签项   --------------------------*/
                    inputHelper.find("ul").append(tag_list);
                    /*--------------------  添加相关标签项   --------------------------*/
                    inputHelper.find("ul li").bind('hover',relatTagsHover).first().addClass("current_tag");
                    _old_k = _keyword;
                });
            }
        }
    };

    //定义判断按键函数
    function checkKey(e){
        var relatTags=$("#input_helper ul li");
        var currentTag=$(".current_tag");
        var keyNum;
        try {
            keyNum = event.keyCode;
        } catch (err) {
            keyNum = e.keyCode;                 //For FF
        };
        switch (keyNum){
            case 40:                //按了向下的键
                if(currentTag.index()==relatTags.last().index()){
                    currentTag.removeClass("current_tag");
                    relatTags.first().addClass("current_tag");
                }else{
                    currentTag.removeClass("current_tag").next().addClass("current_tag");
                };
                break;
            case 38:                //按了向上的键
                if(currentTag.index()==relatTags.first().index()){
                    currentTag.removeClass("current_tag");
                    relatTags.last().addClass("current_tag");
                }else{
                    currentTag.removeClass("current_tag").prev().addClass("current_tag");
                };
                break;
            case 13:                //回车键
                var spanHtml=currentTag.find("span").html();
                if(spanHtml==null){
                    $("#input_helper").hide();
                    break;
                }else{
                    var _val = spanHtml;
                    var oid = currentTag.find("span").attr('oid');
                    if(typeof(oid) != 'undefined') {
                        _params = '&tag_id='+oid;
                    } else {
                        _params = '';
                    }
                    ajaxAddTag(_val, _params);
                };
                break;
        };
    };

    //定义点击添加标签事件(冒泡cklick)
    function clickAdd(my_obj){
        var clicked = $(my_obj.target);
        var _val = null;
        var oid = null;
        var _params = null;
        if(clicked.is("li") || clicked.is("span") || clicked.is("a")){
            if(clicked.is("li") || clicked.is("a")) {
                _val = clicked.find("span").html();
                oid = clicked.find("span").attr('oid');
                _params = '&tag_id='+oid;
            } else {
                _val = clicked.html();
                _params = '';
            }

            ajaxAddTag(_val, _params);
        };
    };

    /**
     * ajax添加tag操作
     *
     * @author ccy@paidai.com
     * @since 2011-12-30
     *
     */
    function ajaxAddTag(_val, _params) {
        $.getJSON(urls_tag_mng+'?act=ajax03&msg=ok&format=json&k='+_val+'&topic_id='+tag_relation_obj_id+_params+'&type='+tag_relation_type+'&author_id='+topic_author_id+'&jsoncallback=?', function(data){
            if(data.error == 0) {
                oid = data.content;
                relation_id = data.relation_id;

                // 同义词转换
                if(data.dest_name) {
                    _val = data.dest_name;
                }
                if(data.uid) {
                    _uid = data.uid;
                }

                var newTag=('<li><a href="http://www.paidai.com/labels/'+encodeURIComponent(_val)+'.html" oid="'+relation_id+'" uid="'+_uid+'" class="tags" target="_blank">'+_val+'</a><a href="javascript:void(0);" class="del_ico"></a>');
                $(".mytags ul").append(newTag);
                $("#add_tag_text").val('');
                $("#input_helper ul").empty();
                $("#input_helper").hide();
                $("#add_tag_text").focus();
                $("#no_list_tip").remove();
                _old_k = null;
                $('.mytags li').last().attr('style','z-index:' + tags_z_index);        //为新添加的标签增加z-index属性
                tags_z_index--;    
            } else {
                _boxy = new Boxy('<div style="width:260px;height:60px;color:blue;">' + data.content + '</div>', {modal:true} );
                setTimeout( function(){ _boxy.hide(); }, 2000);
            }
        });
    }

    //相关标签鼠标敏感
    function relatTagsHover(){
            $("#input_helper ul li").removeClass("current_tag");
            $(this).addClass("current_tag");
        };

    //定义输入框失去焦点事件
    $(document).click(function(obj){
        activeObj= document.activeElement;
        activeObj=$(activeObj);
        if(!(activeObj.is("#add_tag_text"))){        //输入框以外的点击
            $("#input_helper").find("ul").empty().end().hide();
        };
    });

    //点击完成按钮
    $("#add_tag_btn").click(function(){
        $("#input_helper ul").empty();
        $("#input_helper").hide();
        $(".del_ico").remove();
        $(".mytags").css("width","480px")
        $("#add_tag").hide();
        $("#change_note").fadeIn("nomal");
        _old_k = null;
        $(".new_tag").attr('style','background:url(http://www.paidai.com/images/bbs/topic/new_tag_bg.gif) no-repeat right bottom;'); //点击完成按钮，添加新标签背景图片add@20120323by-rxq
        tag_modify_flag = false;
    });
//--------------------------------------------指向标签显示【标签说明框】及反色效果add@20120323by-rxq
    $('.mytags ul li').live('mouseenter',function(){
        $(this).css({'background':'#5f7a5b','border':'1px solid #5f7a5b'}).find('.tag_note').show().end().find('.tags').css({'color':'#fff','background':'#5f7a5b'}).end().find('.del_ico').css('background-position','0 -25px');
    }).live('mouseleave',function(){
        $(this).css({'background':'#e9f5e7','border':'1px solid #cee3c7'}).find('.tag_note').hide().end().find('.tags').css({'color':'#5f7a5b','background':'#e9f5e7'}).end().find('.del_ico').css('background-position','0 0');
        if(!tag_modify_flag){        //未处于修改状态
            $(this).find(".new_tag").attr('style','background:url(http://www.paidai.com/images/bbs/topic/new_tag_bg.gif) no-repeat right bottom;'); 
        }
    })


})
