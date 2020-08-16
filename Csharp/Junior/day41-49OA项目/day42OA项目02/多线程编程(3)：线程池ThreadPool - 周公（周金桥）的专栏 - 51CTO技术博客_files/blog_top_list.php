
var start = 1;

var _html = '<div class="blogpopMain"><div class="l">'
          + '<a href="http://blog.51cto.com/zt/637" target="_blank"><img src="http://s3.51cto.com/wyfs02/M00/2B/B7/wKioL1OIVPKBHx5BAAA5ru468fw372.jpg" width="105" height="105" /></a>'
          + '<p><a href="http://blog.51cto.com/zt/637" target="_blank">从零开始学高德 JS API</a></p></div>'
          + '<div class="r"><h4 style="text-align:left;"><a href="http://edu.51cto.com/pack/view/id-10.html" target="_blank">教你一次搞定计算机网络基础</a></h4>'
          + '<ul>'
          + '<li><a href="http://edu.51cto.com/pack/view/id-18.html" target="_blank">高性能高可用集群架构企业级实战</a></li>'
          + '<li><a href="http://shenyisyn.blog.51cto.com/4968488/1418197" target="_blank"style="color:red;">怎么样才能留住你的员工？</a></li>'
          + '<li><a href="http://chenpipi.blog.51cto.com/8563610/1417004" target="_blank">Linux系统资源常用监控工具汇总</a></li>'
          + '<li><a href="http://yaocoder.blog.51cto.com/2668309/1416730" target="_blank"style="color:red;">如何组建一个合理的研发团队？</a></li>'
          + '</ul>'
          + '</div></div>'
          + '';

jQuery('#showMessagerDim').show();

jQuery(function(){
//window.onload=function(){
   if(get_cookie('blog_top')==''&&start==1){
//	 show_pop();
	    jQuery.messager.showblogtop('', _html);
        var date=new Date();
	    var day = 1401552000000;//
	    date.setTime(day);
	    var test = date.getTime();
	    document.cookie="blog_top=yes;domain=.blog.51cto.com;expires="+date.toGMTString()+";path=/;";
    }
	jQuery("#showMessagerDim").click(function(){
		jQuery.messager.showblogtop('', _html);
		//removeIframe();
	});
//}
});


function get_cookie(Name) {
    var search = Name + "=";
    var returnvalue = "";
    if (document.cookie.length > 0) {
        offset = document.cookie.indexOf(search);
        if (offset != -1) {
            offset += search.length;

            end1 = document.cookie.indexOf(";", offset);

            if (end1 == -1)
            end1 = document.cookie.length;
            returnvalue=unescape(document.cookie.substring(offset, end1));
        }
    }
    return returnvalue;
}

