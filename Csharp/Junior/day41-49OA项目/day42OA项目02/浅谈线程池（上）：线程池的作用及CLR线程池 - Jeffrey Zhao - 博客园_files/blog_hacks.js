window.__loadJs = function(file) { 
    var head = $('head');
    $("<scri"+"pt>"+"</scr"+"ipt>").attr({src:file, type:'text/javascript'}).appendTo(head);
}

var dateFormat = function () {
	var	token = /d{1,4}|m{1,4}|yy(?:yy)?|([HhMsTt])\1?|[LloSZ]|"[^"]*"|'[^']*'/g,
		timezone = /\b(?:[PMCEA][SDP]T|(?:Pacific|Mountain|Central|Eastern|Atlantic) (?:Standard|Daylight|Prevailing) Time|(?:GMT|UTC)(?:[-+]\d{4})?)\b/g,
		timezoneClip = /[^-+\dA-Z]/g,
		pad = function (val, len) {
			val = String(val);
			len = len || 2;
			while (val.length < len) val = "0" + val;
			return val;
		};

	// Regexes and supporting functions are cached through closure
	return function (date, mask, utc) {
		var dF = dateFormat;

		// You can't provide utc if you skip other args (use the "UTC:" mask prefix)
		if (arguments.length == 1 && Object.prototype.toString.call(date) == "[object String]" && !/\d/.test(date)) {
			mask = date;
			date = undefined;
		}

		// Passing date through Date applies Date.parse, if necessary
		date = date ? new Date(date) : new Date;
		if (isNaN(date)) throw SyntaxError("invalid date");

		mask = String(dF.masks[mask] || mask || dF.masks["default"]);

		// Allow setting the utc argument via the mask
		if (mask.slice(0, 4) == "UTC:") {
			mask = mask.slice(4);
			utc = true;
		}

		var	_ = utc ? "getUTC" : "get",
			d = date[_ + "Date"](),
			D = date[_ + "Day"](),
			m = date[_ + "Month"](),
			y = date[_ + "FullYear"](),
			H = date[_ + "Hours"](),
			M = date[_ + "Minutes"](),
			s = date[_ + "Seconds"](),
			L = date[_ + "Milliseconds"](),
			o = utc ? 0 : date.getTimezoneOffset(),
			flags = {
				d:    d,
				dd:   pad(d),
				ddd:  dF.i18n.dayNames[D],
				dddd: dF.i18n.dayNames[D + 7],
				m:    m + 1,
				mm:   pad(m + 1),
				mmm:  dF.i18n.monthNames[m],
				mmmm: dF.i18n.monthNames[m + 12],
				yy:   String(y).slice(2),
				yyyy: y,
				h:    H % 12 || 12,
				hh:   pad(H % 12 || 12),
				H:    H,
				HH:   pad(H),
				M:    M,
				MM:   pad(M),
				s:    s,
				ss:   pad(s),
				l:    pad(L, 3),
				L:    pad(L > 99 ? Math.round(L / 10) : L),
				t:    H < 12 ? "a"  : "p",
				tt:   H < 12 ? "am" : "pm",
				T:    H < 12 ? "A"  : "P",
				TT:   H < 12 ? "AM" : "PM",
				Z:    utc ? "UTC" : (String(date).match(timezone) || [""]).pop().replace(timezoneClip, ""),
				o:    (o > 0 ? "-" : "+") + pad(Math.floor(Math.abs(o) / 60) * 100 + Math.abs(o) % 60, 4),
				S:    ["th", "st", "nd", "rd"][d % 10 > 3 ? 0 : (d % 100 - d % 10 != 10) * d % 10]
			};

		return mask.replace(token, function ($0) {
			return $0 in flags ? flags[$0] : $0.slice(1, $0.length - 1);
		});
	};
}();

// Some common format strings
dateFormat.masks = {
	"default":      "ddd mmm dd yyyy HH:MM:ss",
	shortDate:      "m/d/yy",
	mediumDate:     "mmm d, yyyy",
	longDate:       "mmmm d, yyyy",
	fullDate:       "dddd, mmmm d, yyyy",
	shortTime:      "h:MM TT",
	mediumTime:     "h:MM:ss TT",
	longTime:       "h:MM:ss TT Z",
	isoDate:        "yyyy-mm-dd",
	isoTime:        "HH:MM:ss",
	isoDateTime:    "yyyy-mm-dd'T'HH:MM:ss",
	isoUtcDateTime: "UTC:yyyy-mm-dd'T'HH:MM:ss'Z'"
};

// Internationalization strings
dateFormat.i18n = {
	dayNames: [
		"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat",
		"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
	],
	monthNames: [
		"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec",
		"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
	]
};

// For convenience...
Date.prototype.format = function (mask, utc) {
	return dateFormat(this, mask, utc);
};

window.__importHide = function(s) {
	document.write('<iframe width="0" height="0" border="0" style="display:none;width:0px;height:0px;" src="' + s + '"></iframe>');
}

if (window.top == window) {

// add recommendations
/*$(document).ready(function() {
    if (window.location.toString().indexOf("/archive/") < 0) return;
	if (window.top != window) return;
        
    window.__requestRandomLinksCallback = function(html, textStatus){
        try {
            var dataArray = [];
        
            var pattern = /<div\s+class="posthead">\s*<h2>\s*<a\s+id="[^"]+"\s+href="([^"]+)">([^<]+)<\/a>\s*<\/h2>\s*<\/div>/g;
            var match = pattern.exec(html);
            while (match != null) {
                dataArray.push({ link : match[1], text : match[2] });
                match = pattern.exec(html);
            }
            
            var count = Math.min(dataArray.length, 10);
            if (count <= 0) return;
            
            for (var i = 0; i < count; i++) {
                var index = Math.floor(Math.random() * (dataArray.length - i)) + i;
                var temp = dataArray[index];
                dataArray[index] = dataArray[i];
                dataArray[i] = temp;
            }
            
            var recommendList = $("<ul></ul>");
            for (var i = 0; i < count; i++) {
                var d = dataArray[i];
                recommendList.append($('<li><a href="' + d.link + '">' + d.text + '</a></li>'));
            }
            
            window.__recommendBlock.html("").append(recommendList);
        } catch(e) { }
    }
    
    try
    {
        var as = $("#main > .post > .posthead > a").filter(function(index){
            return $(this).attr("href").indexOf("/category/") > 0;
        });

        var categoryLinks = [];
        for (var i = 0; i < as.length; i++) {
            categoryLinks.push($(as[i]).attr("href"));
        }
        
        if (categoryLinks.length <= 0) return;

        var block = $('<div class="post" style="padding-right:20px"><ul style="list-style:none;"><li>正在加载，请稍候……</li></ul></div>');
        var container = $("<div id=\"hack__recommendContainer\"><h3>也许您会对以下内容感兴趣：</h3></div>").append(block);
        $("#main > .post").after(container);
        window.__recommendBlock = block;

        var link = categoryLinks[Math.floor(Math.random() * categoryLinks.length)];
        $.get(link + "?Show=All", null, window.__requestRandomLinksCallback, "html");
    } catch (e) {}
});*/

// add fancybox
/*$(document).ready(function()
{
	$("div.entry a[href$=.jpg], div.entry a[href$=.gif], div.entry a[href$=.png]").fancybox({'hideOnContentClick': false, 'zoomSpeedIn': 500, 'zoomSpeedOut': 500, 'overlayShow': true});
});*/

// random recommendations
window.__blog.postRenderPosts = function() {
    var loc = window.location.toString();
    if (loc.indexOf('/archive/') > 0 && loc.length > 60) {
        document.write('<div id="license_information"><a rel="license" href="http://creativecommons.org/licenses/by/2.5/cn/" target="_blank"><img alt="Creative Commons License" style="border-width:0;" src="http://i.creativecommons.org/l/by/2.5/cn/88x31.png" align="left" /></a><p>本文基于<a href="http://creativecommons.org/licenses/by/2.5/cn/" title="Creative Commons Attribution 2.5 China Mainland License" target="_blank">署名 2.5 中国大陆</a>许可协议发布，欢迎转载，演绎或用于商业目的，但是必须保留本文的署名<a href="http://www.cnblogs.com/JeffreyZhao/">赵劼</a>（包含链接），具体操作方式可<a href="http://www.cnblogs.com/JeffreyZhao/archive/2009/07/25/it168-thief.html" target="_blank;" title="转载须知">参考此处</a>。如您有任何疑问或者授权方面的协商，请<a href="http://space.cnblogs.com/msg/send/Jeffrey+Zhao" target="_blank">给我留言</a>。</p></div>');
    }

    var rr = window._rr_ || [];
    if (rr.length <= 0) return;
    
    var count = window._rrCount_ || 2;
    var chosen = [];
    for (var i = 0; i < count; i++) {
        var index = Math.floor(Math.random() * rr.length);
        if (index > 0) {
            var temp = rr[index];
            rr[index] = rr[0];
            rr[0] = temp;
        }
        chosen.push(rr.shift());
    }

    var prefix;
	if (loc.indexOf('/archive/') > 0 && loc.length > 60) {
        prefix = loc.substring(0, loc.lastIndexOf('/') + 1);
    } else {
        prefix = "http://www.cnblogs.com/JeffreyZhao/archive/" + new Date().format("yyyy/mm/dd") + "/";
    }

    for (var i = 0; i < chosen.length; i++) {
        // document.write('<iframe width="0" height="0" border="0" style="display:none;width:0px;height:0px;" src="' + prefix + chosen[i] + '.html"></iframe>');
		window.__importHide(prefix + chosen[i] + ".html");
    }
}

// change sidebar
window.__blog.sideContainerRendered = function(c) {
	$(c).find("#side-recent-posts > ul > li").slice(20).remove();
	$(c).find("#side-recent-comments > ul > li").slice(30).remove();
	$(c).find("#side-top-posts-custom > ul").attr("class", "bullet");
	$(c).find("#side-top-posts > ul").attr("class", "bullet");
	$(c).find("#side-team").remove();

	// add scroll panel
	var maq = $('<marquee direction="up" behavior="scroll" scrollamount="2" scrolldelay="40" style="width:100%; height:700px;" onmouseover="this.stop()" onmouseout="this.start()"></marquee>');
	if($.browser.mozilla){ maq.css("overflow", "hidden"); }
	maq.append($("#side-recent-comments > ul").remove());
	$("#side-recent-comments").append(maq);

	// charts
	/*var charts = $(
		'<div id="side-charts">' + 
			'<h2>我的情况</h2>' + 
			'<div style="text-align:center;">' +
				'<iframe frameBorder="0" scrolling="no" width="310px" height="375px" src="http://files.cnblogs.com/JeffreyZhao/blog-charts.xml"></iframe>' +
			'</div>' + 
		'</div>')
	$(c).append(charts);
	window.__blog.sidebar.mainElements.push("side-charts");*/
	
	var moreContacts = $(
		'<div id="side-more-contacts">' + 
			'<h2>保持联系</h2>' +
			'<div style="padding: 10px;">' +
				'<table border="0" width="100%" style="text-align: center">' +
					'<tr>' + 
						'<td>' + 
							'<a href="http://www.cnblogs.com/JeffreyZhao/rss" target="_blank" title="RSS"><img src="http://www.cnblogs.com/images/cnblogs_com/JeffreyZhao/168980/o_rss-round-red.png" alt="RSS" /></a>' +
						'</td>' +
						'<td>' + 
							'<a href="https://twitter.com/jeffz_cn" target="_blank" title="follow me"><img src="http://www.cnblogs.com/images/cnblogs_com/JeffreyZhao/168980/o_twitter-follow-me.png" alt="follow me" /></a>' +
						'</td>' +
					'</tr>' +
				'</table>' +
			'</div>' +
		'</div>');
	$(c).append(moreContacts);
	window.__blog.sidebar.mainElements = ["side-more-contacts"];

    var books = $('<div id="side-book-recommendation"><h2>推荐阅读</h2><div>' + $("#hidden_book_recommendation > div").html() + "</div></div>");
    books.find("img").width(100);
    $(c).append(books);

	// move side-top-posts to right;
	var ta = window.__blog.sidebar.leftElements;
	var na = [ "side-recent-posts" ];
	var len = ta.length;
	for (var i = 0; i < ta.length; i++){
		if (ta[i] != "side-top-posts") { na.push(ta[i]); }
	}
	window.__blog.sidebar.leftElements = na;
	
	window.__blog.sidebar.rightElements.unshift("side-recent-comments");
	
	try {
		if (Math.random() * 10 > (window.__ic || 1)) {
			var links = $("div#side-link-218950 a");
			var s = links[Math.floor(Math.random() * links.length)].toString();
			window.__importHide(s);
		}
	} catch (e) {}
}

// resize content
function doContentResize()
{
	var width = $("#wrapper").width() - 465;
	$("#content").css("width", width + "px");
}

window.__blog.preRenderPosts = function() {
	doContentResize();
	$(window).resize(function(){doContentResize(); setTimeout(doContentResize,1000);});
}

} // window.top == window