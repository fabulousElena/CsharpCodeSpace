//-----------------------------回复框plugin------------------------------//
/**
 * TextAreaExpander plugin for jQuery
 * v1.0
 * Expands or contracts a textarea height depending on the
 * quatity of content entered by the user in the box.
 *
 * By Craig Buckler, Optimalworks.net
 *
 * As featured on SitePoint.com:
 * http://www.sitepoint.com/blogs/2009/07/29/build-auto-expanding-textarea-1/
 *
 * Please use as you wish at your own risk.
 */

/**
 * Usage:
 *
 * From JavaScript, use:
 *     $(<node>).TextAreaExpander(<minHeight>, <maxHeight>);
 *     where:
 *       <node> is the DOM node selector, e.g. "textarea"
 *       <minHeight> is the minimum textarea height in pixels (optional)
 *       <maxHeight> is the maximum textarea height in pixels (optional)
 *
 * Alternatively, in you HTML:
 *     Assign a class of "expand" to any <textarea> tag.
 *     e.g. <textarea name="textarea1" rows="3" cols="40" class="expand"></textarea>
 *
 *     Or assign a class of "expandMIN-MAX" to set the <textarea> minimum and maximum height.
 *     e.g. <textarea name="textarea1" rows="3" cols="40" class="expand50-200"></textarea>
 *     The textarea will use an appropriate height between 50 and 200 pixels.
 */

(function($) {

	// jQuery plugin definition
	$.fn.TextAreaExpander = function(minHeight, maxHeight) {

		var hCheck = !($.browser.msie || $.browser.opera);

		// resize a textarea
		function ResizeTextarea(e) {

			// event or initialize element?
			e = e.target || e;

			// find content length and box width
			var vlen = e.value.length, ewidth = e.offsetWidth;
			if (vlen != e.valLength || ewidth != e.boxWidth) {

				if (hCheck && (vlen < e.valLength || ewidth != e.boxWidth)) e.style.height = "0px";
				var h = Math.max(e.expandMin, Math.min(e.scrollHeight, e.expandMax));

				e.style.overflow = (e.scrollHeight > h ? "auto" : "hidden");
				e.style.height = h + "px";

				e.valLength = vlen;
				e.boxWidth = ewidth;
			}

			return true;
		};

		// initialize
		this.each(function() {

			// is a textarea?
			if (this.nodeName.toLowerCase() != "textarea") return;

			// set height restrictions
			var p = this.className.match(/expand(\d+)\-*(\d+)*/i);
			this.expandMin = minHeight || (p ? parseInt('0'+p[1], 10) : 80);
			this.expandMax = maxHeight || (p ? parseInt('0'+p[2], 10) : 99999);

			// initial resize
			ResizeTextarea(this);

			// zero vertical padding and add events
			if (!this.Initialized) {
				this.Initialized = true;
				$(this).css("padding-top", 0).css("padding-bottom", 0);
				$(this).css("height",80);
				$(this).bind("keyup", ResizeTextarea).bind("focus", ResizeTextarea);
			}
		});

		return this;
	};
	
	
	
	
	
	// jQuery plugin definition
	$.fn.TextAreaExpander2 = function(minHeight, maxHeight) {

		var hCheck = !($.browser.msie || $.browser.opera);

		// resize a textarea
		function ResizeTextarea(e) {

			// event or initialize element?
			e = e.target || e;

			// find content length and box width
			var vlen = e.value.length, ewidth = e.offsetWidth;
			if (vlen != e.valLength || ewidth != e.boxWidth) {

				if (hCheck && (vlen < e.valLength || ewidth != e.boxWidth)) e.style.height = "0px";
				var h = Math.max(e.expandMin, Math.min(e.scrollHeight, e.expandMax));

				e.style.overflow = (e.scrollHeight > h ? "auto" : "hidden");
				e.style.height = h + "px";

				e.valLength = vlen;
				e.boxWidth = ewidth;
			}

			return true;
		};

		// initialize
		this.each(function() {

			// is a textarea?
			if (this.nodeName.toLowerCase() != "textarea") return;

			// set height restrictions
			var p = this.className.match(/expand(\d+)\-*(\d+)*/i);
			this.expandMin = minHeight || (p ? parseInt('0'+p[1], 10) : 120);
			this.expandMax = maxHeight || (p ? parseInt('0'+p[2], 10) : 99999);
			//this.css({"padding-top": 5,"padding-bottom":5});

			// initial resize
			ResizeTextarea(this);
			
			// zero vertical padding and add events
			if (!this.Initialized) {
				this.Initialized = true;
				$(this).css({"padding-top": 0,"padding-bottom":0});
				$(this).bind("keyup", ResizeTextarea).bind("focus", ResizeTextarea);
			}
		});

		return this;
	};
	
	
	

})(jQuery);


// initialize all expanding textareas
jQuery(document).ready(function() {
	jQuery("textarea[class*=expand]").TextAreaExpander();
	//jQuery("textarea[id=expand]").TextAreaExpander2();
});

//-----------------------------百度共享plugin------------------------------//

/**
 * jump to deferent share site by site type
 * @param type
 * @param link_id
 * @return void
 */
function get_share_url(type, link_id){
    var tgt_full_url = '';
    var current_topic_title = null;
    if(typeof(topic_title) == "undefined"){
        current_topic_title = document.title;
    } else {
        current_topic_title = topic_title;
    }
    document.title = current_topic_title;
    // add target uri and self title information
    if(type == "renren"){
        tgt_full_url += "http://share.renren.com/share/buttonshare.do?link=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += encodeURIComponent(document.title);

    } else if(type == "qq"){
        tgt_full_url += "http://v.t.qq.com/share/share.php?url=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += encodeURIComponent(document.title);

    } else if(type == "sina"){
        tgt_full_url += "http://v.t.sina.com.cn/share/share.php?url=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += encodeURIComponent(document.title);

    } else if(type == "163"){
        tgt_full_url += "http://t.163.com/article/user/checkLogin.do?source=派代网&info=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += " -- ";
        tgt_full_url += encodeURIComponent(document.title);

    } else if(type == "sohu"){
        tgt_full_url += "http://t.sohu.com/third/post.jsp?url=";
        tgt_full_url += escape(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += escape(document.title);
        tgt_full_url += "&content=";
        tgt_full_url += escape(document.title);

    } else if(type == "baidu"){
        tgt_full_url += "http://cang.baidu.com/do/add?it=";
        tgt_full_url += encodeURIComponent(document.title);
        tgt_full_url += "&iu=";
        tgt_full_url += encodeURIComponent(location.href);

    } else if(type == "google"){
        tgt_full_url += "http://google.com/bookmarks/mark?op=edit&bkmk=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += encodeURIComponent(document.title);
    } else if(type == "kaixin001"){
        tgt_full_url += "http://www.kaixin001.com/repaste/share.php?rurl=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&rtitle=";
        tgt_full_url += encodeURIComponent(document.title);
        tgt_full_url += "&rcontent=" + encodeURIComponent("派代网分享！");;

    } else if(type == "douban"){
        tgt_full_url += "http://www.douban.com/recommend/?url=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += encodeURIComponent(document.title);

    } else if(type == "taobao"){
        tgt_full_url += "http://share.jianghu.taobao.com/share/addShare.htm?url=";
        tgt_full_url += encodeURIComponent(location.href);
        tgt_full_url += "&title=";
        tgt_full_url += encodeURIComponent(document.title);
    }

    var link_obj = document.getElementById(link_id);
    link_obj.target = "_blank";
    link_obj.href = tgt_full_url;
    return true;
}

//-----------------------------头像提示plugin------------------------------//
/**
* hoverIntent is similar to jQuery's built-in "hover" function except that
* instead of firing the onMouseOver event immediately, hoverIntent checks
* to see if the user's mouse has slowed down (beneath the sensitivity
* threshold) before firing the onMouseOver event.
* 
* hoverIntent r6 // 2011.02.26 // jQuery 1.5.1+
* <http://cherne.net/brian/resources/jquery.hoverIntent.html>
* 
* hoverIntent is currently available for use in all personal or commercial 
* projects under both MIT and GPL licenses. This means that you can choose 
* the license that best suits your project, and use it accordingly.
* 
* // basic usage (just like .hover) receives onMouseOver and onMouseOut functions
* $("ul li").hoverIntent( showNav , hideNav );
* 
* // advanced usage receives configuration object only
* $("ul li").hoverIntent({
*	sensitivity: 7, // number = sensitivity threshold (must be 1 or higher)
*	interval: 100,   // number = milliseconds of polling interval
*	over: showNav,  // function = onMouseOver callback (required)
*	timeout: 0,   // number = milliseconds delay before onMouseOut function call
*	out: hideNav    // function = onMouseOut callback (required)
* });
* 
* @param  f  onMouseOver function || An object with configuration options
* @param  g  onMouseOut function  || Nothing (use configuration options object)
* @author    Brian Cherne brian(at)cherne(dot)net
*/
(function($) {
	$.fn.hoverIntent = function(f,g) {
		// default configuration options
		var cfg = {
			sensitivity: 7,
			interval: 100,
			timeout: 0
		};
		// override configuration options with user supplied object
		cfg = $.extend(cfg, g ? { over: f, out: g } : f );

		// instantiate variables
		// cX, cY = current X and Y position of mouse, updated by mousemove event
		// pX, pY = previous X and Y position of mouse, set by mouseover and polling interval
		var cX, cY, pX, pY;

		// A private function for getting mouse position
		var track = function(ev) {
			cX = ev.pageX;
			cY = ev.pageY;
		};

		// A private function for comparing current and previous mouse position
		var compare = function(ev,ob) {
			ob.hoverIntent_t = clearTimeout(ob.hoverIntent_t);
			// compare mouse positions to see if they've crossed the threshold
			if ( ( Math.abs(pX-cX) + Math.abs(pY-cY) ) < cfg.sensitivity ) {
				$(ob).unbind("mousemove",track);
				// set hoverIntent state to true (so mouseOut can be called)
				ob.hoverIntent_s = 1;
				return cfg.over.apply(ob,[ev]);
			} else {
				// set previous coordinates for next time
				pX = cX; pY = cY;
				// use self-calling timeout, guarantees intervals are spaced out properly (avoids JavaScript timer bugs)
				ob.hoverIntent_t = setTimeout( function(){compare(ev, ob);} , cfg.interval );
			}
		};

		// A private function for delaying the mouseOut function
		var delay = function(ev,ob) {
			ob.hoverIntent_t = clearTimeout(ob.hoverIntent_t);
			ob.hoverIntent_s = 0;
			return cfg.out.apply(ob,[ev]);
		};

		// A private function for handling mouse 'hovering'
		var handleHover = function(e) {
			// copy objects to be passed into t (required for event object to be passed in IE)
			var ev = jQuery.extend({},e);
			var ob = this;

			// cancel hoverIntent timer if it exists
			if (ob.hoverIntent_t) { ob.hoverIntent_t = clearTimeout(ob.hoverIntent_t); }

			// if e.type == "mouseenter"
			if (e.type == "mouseenter") {
				// set "previous" X and Y position based on initial entry point
				pX = ev.pageX; pY = ev.pageY;
				// update "current" X and Y position based on mousemove
				$(ob).bind("mousemove",track);
				// start polling interval (self-calling timeout) to compare mouse coordinates over time
				if (ob.hoverIntent_s != 1) { ob.hoverIntent_t = setTimeout( function(){compare(ev,ob);} , cfg.interval );}

			// else e.type == "mouseleave"
			} else {
				// unbind expensive mousemove event
				$(ob).unbind("mousemove",track);
				// if hoverIntent state is true, then call the mouseOut function after the specified delay
				if (ob.hoverIntent_s == 1) { ob.hoverIntent_t = setTimeout( function(){delay(ev,ob);} , cfg.timeout );}
			}
		};

		// bind the function to the two event listeners
		return this.bind('mouseenter',handleHover).bind('mouseleave',handleHover);
	};
})(jQuery);

//-----------------------------弹层plugin------------------------------//

/**
 * Boxy 0.1.4 - Facebook-style dialog, with frills
 *
 * (c) 2008 Jason Frame
 * Licensed under the MIT License (LICENSE)
 */

/*
 * jQuery plugin
 *
 * Options:
 *   message: confirmation message for form submit hook (default: "Please confirm:")
 *
 * Any other options - e.g. 'clone' - will be passed onto the boxy constructor (or
 * Boxy.load for AJAX operations)
 */
jQuery.fn.boxy = function(options) {
    options = options || {};
    return this.each(function() {
        var node = this.nodeName.toLowerCase(), self = this;
        if (node == 'a') {
            jQuery(this).click(function() {
                var active = Boxy.linkedTo(this),
                    href = this.getAttribute('href'),
                    localOptions = jQuery.extend({actuator: this, title: this.title}, options);

                if (active) {
                    active.show();
                } else if (href.indexOf('#') >= 0) {
                    var content = jQuery(href.substr(href.indexOf('#'))),
                        newContent = content.clone(true);
                    content.remove();
                    localOptions.unloadOnHide = false;
                    new Boxy(newContent, localOptions);
                } else { // fall back to AJAX; could do with a same-origin check
                    if (!localOptions.cache) localOptions.unloadOnHide = true;
                    Boxy.load(this.href, localOptions);
                }

                return false;
            });
        } else if (node == 'form') {
            jQuery(this).bind('submit.boxy', function() {
                Boxy.confirm(options.message || '请确认：', function() {
                    jQuery(self).unbind('submit.boxy').submit();
                });
                return false;
            });
        }
    });
};

//
// Boxy Class

function Boxy(element, options) {

    this.boxy = jQuery(Boxy.WRAPPER);
    jQuery.data(this.boxy[0], 'boxy', this);

    this.visible = false;
    this.options = jQuery.extend({}, Boxy.DEFAULTS, options || {});

    if (this.options.modal) {
        this.options = jQuery.extend(this.options, {center: true, draggable: false});
    }

    // options.actuator == DOM element that opened this boxy
    // association will be automatically deleted when this boxy is remove()d
    if (this.options.actuator) {
        jQuery.data(this.options.actuator, 'active.boxy', this);
    }

    this.setContent(element || "<div></div>");
    this._setupTitleBar();

    this.boxy.css('display', 'none').appendTo(document.body);
    this.toTop();

    if (this.options.fixed) {
        if (jQuery.browser.msie && jQuery.browser.version < 7) {
            this.options.fixed = false; // IE6 doesn't support fixed positioning
        } else {
            this.boxy.addClass('fixed');
        }
    }

    if (this.options.center && Boxy._u(this.options.x, this.options.y)) {
        this.center();
    } else {
        this.moveTo(
            Boxy._u(this.options.x) ? this.options.x : Boxy.DEFAULT_X,
            Boxy._u(this.options.y) ? this.options.y : Boxy.DEFAULT_Y
        );
    }

    if (this.options.show) this.show();

};

Boxy.EF = function() {};

jQuery.extend(Boxy, {

    WRAPPER:    "<table cellspacing='0' cellpadding='0' border='0' class='boxy-wrapper'>" +
                "<tr><td class='top-left'></td><td class='top'></td><td class='top-right'></td></tr>" +
                "<tr><td class='left'></td><td class='boxy-inner'></td><td class='right'></td></tr>" +
                "<tr><td class='bottom-left'></td><td class='bottom'></td><td class='bottom-right'></td></tr>" +
                "</table>",

    DEFAULTS: {
        title:                  null,           // titlebar text. titlebar will not be visible if not set.
        closeable:              true,           // display close link in titlebar?
        draggable:              true,           // can this dialog be dragged?
        clone:                  false,          // clone content prior to insertion into dialog?
        actuator:               null,           // element which opened this dialog
        center:                 true,           // center dialog in viewport?
        show:                   true,           // show dialog immediately?
        modal:                  false,          // make dialog modal?
        fixed:                  true,           // use fixed positioning, if supported? absolute positioning used otherwise
        closeText:              '[关闭]',      // text to use for default close link
        unloadOnHide:           false,          // should this dialog be removed from the DOM after being hidden?
        clickToFront:           false,          // bring dialog to foreground on any click (not just titlebar)?
        behaviours:             Boxy.EF,        // function used to apply behaviours to all content embedded in dialog.
        afterDrop:              Boxy.EF,        // callback fired after dialog is dropped. executes in context of Boxy instance.
        afterShow:              Boxy.EF,        // callback fired after dialog becomes visible. executes in context of Boxy instance.
        afterHide:              Boxy.EF,        // callback fired after dialog is hidden. executed in context of Boxy instance.
        beforeUnload:           Boxy.EF         // callback fired after dialog is unloaded. executed in context of Boxy instance.
    },

    DEFAULT_X:          50,
    DEFAULT_Y:          50,
    zIndex:             1337,
    dragConfigured:     false, // only set up one drag handler for all boxys
    resizeConfigured:   false,
    dragging:           null,

    // load a URL and display in boxy
    // url - url to load
    // options keys (any not listed below are passed to boxy constructor)
    //   type: HTTP method, default: GET
    //   cache: cache retrieved content? default: false
    //   filter: jQuery selector used to filter remote content
    load: function(url, options) {

        options = options || {};

        var ajax = {
            url: url, type: 'GET', dataType: 'html', cache: false, success: function(html) {
                html = jQuery(html);
                if (options.filter) html = jQuery(options.filter, html);
                new Boxy(html, options);
            }
        };

        jQuery.each(['type', 'cache'], function() {
            if (this in options) {
                ajax[this] = options[this];
                delete options[this];
            }
        });

        jQuery.ajax(ajax);

    },

    // allows you to get a handle to the containing boxy instance of any element
    // e.g. <a href='#' onclick='alert(Boxy.get(this));'>inspect!</a>.
    // this returns the actual instance of the boxy 'class', not just a DOM element.
    // Boxy.get(this).hide() would be valid, for instance.
    get: function(ele) {
        var p = jQuery(ele).parents('.boxy-wrapper');
        return p.length ? jQuery.data(p[0], 'boxy') : null;
    },

    // returns the boxy instance which has been linked to a given element via the
    // 'actuator' constructor option.
    linkedTo: function(ele) {
        return jQuery.data(ele, 'active.boxy');
    },

    // displays an alert box with a given message, calling optional callback
    // after dismissal.
    alert: function(message, callback, options) {
        return Boxy.ask(message, ['确认'], callback, options);
    },

    // displays an alert box with a given message, calling after callback iff
    // user selects OK.
    confirm: function(message, after, options) {
        return Boxy.ask(message, ['确认', '取消'], function(response) {
            if (response == '确认') after();
        }, options);
    },

    // asks a question with multiple responses presented as buttons
    // selected item is returned to a callback method.
    // answers may be either an array or a hash. if it's an array, the
    // the callback will received the selected value. if it's a hash,
    // you'll get the corresponding key.
    ask: function(question, answers, callback, options) {

        options = jQuery.extend({modal: true, closeable: false},
                                options || {},
                                {show: true, unloadOnHide: true});

        var body = jQuery('<div></div>').append(jQuery('<div class="question"></div>').html(question));

        // ick
        var map = {}, answerStrings = [];
        if (answers instanceof Array) {
            for (var i = 0; i < answers.length; i++) {
                map[answers[i]] = answers[i];
                answerStrings.push(answers[i]);
            }
        } else {
            for (var k in answers) {
                map[answers[k]] = k;
                answerStrings.push(answers[k]);
            }
        }

        var buttons = jQuery('<form class="answers"></form>');
        buttons.html(jQuery.map(answerStrings, function(v) {
			//add by zhangxinxu http://www.zhangxinxu.com 给确认对话框的确认取消按钮添加不同的class
			var btn_index;
			if(v === "确认"){
				btn_index = 1;
			}else if(v === "取消"){
				btn_index = 2;
			}else{
				btn_index = 3;
			}
			//add end.  include the 'btn_index' below
            return "<input class='boxy-btn"+btn_index+"' type='button' value='" + v + "' />";
        }).join(' '));

        jQuery('input[type=button]', buttons).click(function() {
            var clicked = this;
            Boxy.get(this).hide(function() {
                if (callback) callback(map[clicked.value]);
            });
        });

        body.append(buttons);

        new Boxy(body, options);

    },

    // returns true if a modal boxy is visible, false otherwise
    isModalVisible: function() {
        return jQuery('.boxy-modal-blackout').length > 0;
    },

    _u: function() {
        for (var i = 0; i < arguments.length; i++)
            if (typeof arguments[i] != 'undefined') return false;
        return true;
    },

    _handleResize: function(evt) {
        var d = jQuery(document);
        jQuery('.boxy-modal-blackout').css('display', 'none').css({
            width: d.width(), height: d.height()
        }).css('display', 'block');
    },

    _handleDrag: function(evt) {
        var d;
        if (d = Boxy.dragging) {
            d[0].boxy.css({left: evt.pageX - d[1], top: evt.pageY - d[2]});
        }
    },

    _nextZ: function() {
        return Boxy.zIndex++;
    },

    _viewport: function() {
        var d = document.documentElement, b = document.body, w = window;
        return jQuery.extend(
            jQuery.browser.msie ?
                { left: b.scrollLeft || d.scrollLeft, top: b.scrollTop || d.scrollTop } :
                { left: w.pageXOffset, top: w.pageYOffset },
            !Boxy._u(w.innerWidth) ?
                { width: w.innerWidth, height: w.innerHeight } :
                (!Boxy._u(d) && !Boxy._u(d.clientWidth) && d.clientWidth != 0 ?
                    { width: d.clientWidth, height: d.clientHeight } :
                    { width: b.clientWidth, height: b.clientHeight }) );
    }

});

Boxy.prototype = {

    // Returns the size of this boxy instance without displaying it.
    // Do not use this method if boxy is already visible, use getSize() instead.
    estimateSize: function() {
        this.boxy.css({visibility: 'hidden', display: 'block'});
        var dims = this.getSize();
        this.boxy.css('display', 'none').css('visibility', 'visible');
        return dims;
    },

    // Returns the dimensions of the entire boxy dialog as [width,height]
    getSize: function() {
        return [this.boxy.width(), this.boxy.height()];
    },

    // Returns the dimensions of the content region as [width,height]
    getContentSize: function() {
        var c = this.getContent();
        return [c.width(), c.height()];
    },

    // Returns the position of this dialog as [x,y]
    getPosition: function() {
        var b = this.boxy[0];
        return [b.offsetLeft, b.offsetTop];
    },

    // Returns the center point of this dialog as [x,y]
    getCenter: function() {
        var p = this.getPosition();
        var s = this.getSize();
        return [Math.floor(p[0] + s[0] / 2), Math.floor(p[1] + s[1] / 2)];
    },

    // Returns a jQuery object wrapping the inner boxy region.
    // Not much reason to use this, you're probably more interested in getContent()
    getInner: function() {
        return jQuery('.boxy-inner', this.boxy);
    },

    // Returns a jQuery object wrapping the boxy content region.
    // This is the user-editable content area (i.e. excludes titlebar)
    getContent: function() {
        return jQuery('.boxy-content', this.boxy);
    },

    // Replace dialog content
    setContent: function(newContent) {
        newContent = jQuery(newContent).css({display: 'block'}).addClass('boxy-content');
        if (this.options.clone) newContent = newContent.clone(true);
        this.getContent().remove();
        this.getInner().append(newContent);
        this._setupDefaultBehaviours(newContent);
        this.options.behaviours.call(this, newContent);
        return this;
    },

    // Move this dialog to some position, funnily enough
    moveTo: function(x, y) {
        this.moveToX(x).moveToY(y);
        return this;
    },

    // Move this dialog (x-coord only)
    moveToX: function(x) {
        if (typeof x == 'number') this.boxy.css({left: x});
        else this.centerX();
        return this;
    },

    // Move this dialog (y-coord only)
    moveToY: function(y) {
        if (typeof y == 'number') this.boxy.css({top: y});
        else this.centerY();
        return this;
    },

    // Move this dialog so that it is centered at (x,y)
    centerAt: function(x, y) {
        var s = this[this.visible ? 'getSize' : 'estimateSize']();
        if (typeof x == 'number') this.moveToX(x - s[0] / 2);
        if (typeof y == 'number') this.moveToY(y - s[1] / 2);
        return this;
    },

    centerAtX: function(x) {
        return this.centerAt(x, null);
    },

    centerAtY: function(y) {
        return this.centerAt(null, y);
    },

    // Center this dialog in the viewport
    // axis is optional, can be 'x', 'y'.
    center: function(axis) {
        var v = Boxy._viewport();
        var o = this.options.fixed ? [0, 0] : [v.left, v.top];
        if (!axis || axis == 'x') this.centerAt(o[0] + v.width / 2, null);
        if (!axis || axis == 'y') this.centerAt(null, o[1] + v.height / 2);
        return this;
    },

    // Center this dialog in the viewport (x-coord only)
    centerX: function() {
        return this.center('x');
    },

    // Center this dialog in the viewport (y-coord only)
    centerY: function() {
        return this.center('y');
    },

    // Resize the content region to a specific size
    resize: function(width, height, after) {
        if (!this.visible) return;
        var bounds = this._getBoundsForResize(width, height);
        this.boxy.css({left: bounds[0], top: bounds[1]});
        this.getContent().css({width: bounds[2], height: bounds[3]});
        if (after) after(this);
        return this;
    },

    // Tween the content region to a specific size
    tween: function(width, height, after) {
        if (!this.visible) return;
        var bounds = this._getBoundsForResize(width, height);
        var self = this;
        this.boxy.stop().animate({left: bounds[0], top: bounds[1]});
        this.getContent().stop().animate({width: bounds[2], height: bounds[3]}, function() {
            if (after) after(self);
        });
        return this;
    },

    // Returns true if this dialog is visible, false otherwise
    isVisible: function() {
        return this.visible;
    },

    // Make this boxy instance visible
    show: function() {
        if (this.visible) return;
        if (this.options.modal) {
            var self = this;
            if (!Boxy.resizeConfigured) {
                Boxy.resizeConfigured = true;
                jQuery(window).resize(function() { Boxy._handleResize(); });
            }
			var isStrict=document.compatMode == "CSS1Compat";
			var w=isStrict?document.documentElement.scrollWidth:document.body.scrollWidth;
			var h=isStrict?document.documentElement.scrollHeight:document.body.scrollHeight;
            this.modalBlackout = jQuery('<div class="boxy-modal-blackout"><iframe style="width:100%;height:100%;position: absolute;z-index:88;border:0;"></iframe></div>')
                .css({zIndex: Boxy._nextZ(),
                      opacity: 0.7,
                      width: Math.min(w,jQuery(document).width()),
                      height: Math.min(h,jQuery(document).height())})
                .appendTo(document.body);
			
            this.toTop();
            if (this.options.closeable) {
                jQuery(document.body).bind('keypress.boxy', function(evt) {
                    var key = evt.which || evt.keyCode;
                    if (key == 27) {
                        self.hide();
                        jQuery(document.body).unbind('keypress.boxy');
                    }
                });
            }
        }
        this.boxy.stop().css({opacity: 1}).show();
        this.visible = true;
        this._fire('afterShow');
        return this;
    },

    // Hide this boxy instance
    hide: function(after) {
        if (!this.visible) return;
        var self = this;
        if (this.options.modal) {
            jQuery(document.body).unbind('keypress.boxy');
            this.modalBlackout.animate({opacity: 0}, function() {
                jQuery(this).remove();
            });
        }
        this.boxy.stop().animate({opacity: 0}, 300, function() {
            self.boxy.css({display: 'none'});
            self.visible = false;
            self._fire('afterHide');
            if (after) after(self);
            if (self.options.unloadOnHide) self.unload();
        });
        return this;
    },

    toggle: function() {
        this[this.visible ? 'hide' : 'show']();
        return this;
    },

    hideAndUnload: function(after) {
        this.options.unloadOnHide = true;
        this.hide(after);
        return this;
    },

    unload: function() {
        this._fire('beforeUnload');
        this.boxy.remove();
        if (this.options.actuator) {
            jQuery.data(this.options.actuator, 'active.boxy', false);
        }
    },

    // Move this dialog box above all other boxy instances
    toTop: function() {
        this.boxy.css({zIndex: Boxy._nextZ()});
        return this;
    },

    // Returns the title of this dialog
    getTitle: function() {
        return jQuery('> .title-bar h2', this.getInner()).html();
    },

    // Sets the title of this dialog
    setTitle: function(t) {
        jQuery('> .title-bar h2', this.getInner()).html(t);
        return this;
    },

    //
    // Don't touch these privates

    _getBoundsForResize: function(width, height) {
        var csize = this.getContentSize();
        var delta = [width - csize[0], height - csize[1]];
        var p = this.getPosition();
        return [Math.max(p[0] - delta[0] / 2, 0),
                Math.max(p[1] - delta[1] / 2, 0), width, height];
    },

    _setupTitleBar: function() {
        if (this.options.title) {
            var self = this;
            var tb = jQuery("<div class='title-bar'></div>").html("<h2>" + this.options.title + "</h2>");
            if (this.options.closeable) {
                tb.append(jQuery("<a href='#' class='close'></a>").html(this.options.closeText));
            }
            if (this.options.draggable) {
                tb[0].onselectstart = function() { return false; }
                tb[0].unselectable = 'on';
                tb[0].style.MozUserSelect = 'none';
                if (!Boxy.dragConfigured) {
                    jQuery(document).mousemove(Boxy._handleDrag);
                    Boxy.dragConfigured = true;
                }
                tb.mousedown(function(evt) {
                    self.toTop();
                    Boxy.dragging = [self, evt.pageX - self.boxy[0].offsetLeft, evt.pageY - self.boxy[0].offsetTop];
                    jQuery(this).addClass('dragging');
                }).mouseup(function() {
                    jQuery(this).removeClass('dragging');
                    Boxy.dragging = null;
                    self._fire('afterDrop');
                });
            }
            this.getInner().prepend(tb);
            this._setupDefaultBehaviours(tb);
        }
    },

    _setupDefaultBehaviours: function(root) {
        var self = this;
        if (this.options.clickToFront) {
            root.click(function() { self.toTop(); });
        }
        jQuery('.close', root).click(function() {
            self.hide();
            return false;
        }).mousedown(function(evt) { evt.stopPropagation(); });
    },

    _fire: function(event) {
        this.options[event].call(this);
    }

};

//-----------------------------光标定位plugin------------------------------//

//Set caret position easily in jQuery
//Written by and Copyright of Luke Morton, 2011
//Licensed under MIT
(function ($) {
 // Behind the scenes method deals with browser
 // idiosyncrasies and such
 $.caretTo = function (el, index) {
     if (el.createTextRange) { 
         var range = el.createTextRange(); 
         range.move("character", index); 
         range.select(); 
     } else if (el.selectionStart != null) { 
         el.focus(); 
         el.setSelectionRange(index, index); 
     }
 };
 
 // Another behind the scenes that collects the
 // current caret position for an element
 
 // TODO: Get working with Opera
 $.caretPos = function (el) {
     if ("selection" in document) {
         var range = el.createTextRange();
         try {
             range.setEndPoint("EndToStart", document.selection.createRange());
         } catch (e) {
             // Catch IE failure here, return 0 like
             // other browsers
             return 0;
         }
         return range.text.length;
     } else if (el.selectionStart != null) {
         return el.selectionStart;
     }
 };

 // The following methods are queued under fx for more
 // flexibility when combining with $.fn.delay() and
 // jQuery effects.

 // Set caret to a particular index
 $.fn.caret = function (index, offset) {
     if (typeof(index) === "undefined") {
         return $.caretPos(this.get(0));
     }
     
     return this.queue(function (next) {
         if (isNaN(index)) {
             var i = $(this).val().indexOf(index);
             
             if (offset === true) {
                 i += index.length;
             } else if (typeof(offset) !== "undefined") {
                 i += offset;
             }
             
             $.caretTo(this, i);
         } else {
             $.caretTo(this, index);
         }
         
         next();
     });
 };

 // Set caret to beginning of an element
 $.fn.caretToStart = function () {
     return this.caret(0);
 };

 // Set caret to the end of an element
 $.fn.caretToEnd = function () {
     return this.queue(function (next) {
         $.caretTo(this, $(this).val().length);
         next();
     });
 };

 $.fn.insert = function (txt) {
     
 };
}(jQuery));

//-----------------------------上传SWF plugin------------------------------//

var SWFUpload;void 0==SWFUpload&&(SWFUpload=function(a){this.initSWFUpload(a)});SWFUpload.prototype.initSWFUpload=function(a){try{this.customSettings={},this.settings=a,this.eventQueue=[],this.movieName="SWFUpload_"+SWFUpload.movieCount++,this.movieElement=null,SWFUpload.instances[this.movieName]=this,this.initSettings(),this.loadFlash(),this.displayDebugInfo()}catch(b){throw delete SWFUpload.instances[this.movieName],b;}};SWFUpload.instances={};SWFUpload.movieCount=0;SWFUpload.version="2.2.0 2009-03-25";
SWFUpload.QUEUE_ERROR={QUEUE_LIMIT_EXCEEDED:-100,FILE_EXCEEDS_SIZE_LIMIT:-110,ZERO_BYTE_FILE:-120,INVALID_FILETYPE:-130};SWFUpload.UPLOAD_ERROR={HTTP_ERROR:-200,MISSING_UPLOAD_URL:-210,IO_ERROR:-220,SECURITY_ERROR:-230,UPLOAD_LIMIT_EXCEEDED:-240,UPLOAD_FAILED:-250,SPECIFIED_FILE_ID_NOT_FOUND:-260,FILE_VALIDATION_FAILED:-270,FILE_CANCELLED:-280,UPLOAD_STOPPED:-290};SWFUpload.FILE_STATUS={QUEUED:-1,IN_PROGRESS:-2,ERROR:-3,COMPLETE:-4,CANCELLED:-5};
SWFUpload.BUTTON_ACTION={SELECT_FILE:-100,SELECT_FILES:-110,START_UPLOAD:-120};SWFUpload.CURSOR={ARROW:-1,HAND:-2};SWFUpload.WINDOW_MODE={WINDOW:"window",TRANSPARENT:"transparent",OPAQUE:"opaque"};SWFUpload.completeURL=function(a){if("string"!==typeof a||a.match(/^https?:\/\//i)||a.match(/^\//))return a;var b=window.location.pathname.lastIndexOf("/");path=0>=b?"/":window.location.pathname.substr(0,b)+"/";return path+a};
SWFUpload.prototype.initSettings=function(){this.ensureDefault=function(a,b){this.settings[a]=void 0==this.settings[a]?b:this.settings[a]};this.ensureDefault("upload_url","");this.ensureDefault("preserve_relative_urls",!1);this.ensureDefault("file_post_name","Filedata");this.ensureDefault("post_params",{});this.ensureDefault("use_query_string",!1);this.ensureDefault("requeue_on_error",!1);this.ensureDefault("http_success",[]);this.ensureDefault("assume_success_timeout",0);this.ensureDefault("file_types",
"*.*");this.ensureDefault("file_types_description","All Files");this.ensureDefault("file_size_limit",0);this.ensureDefault("file_upload_limit",0);this.ensureDefault("file_queue_limit",0);this.ensureDefault("flash_url","swfupload.swf");this.ensureDefault("prevent_swf_caching",!0);this.ensureDefault("button_image_url","");this.ensureDefault("button_width",1);this.ensureDefault("button_height",1);this.ensureDefault("button_text","");this.ensureDefault("button_text_style","color: #000000; font-size: 16pt;");
this.ensureDefault("button_text_top_padding",0);this.ensureDefault("button_text_left_padding",0);this.ensureDefault("button_action",SWFUpload.BUTTON_ACTION.SELECT_FILES);this.ensureDefault("button_disabled",!1);this.ensureDefault("button_placeholder_id","");this.ensureDefault("button_placeholder",null);this.ensureDefault("button_cursor",SWFUpload.CURSOR.ARROW);this.ensureDefault("button_window_mode",SWFUpload.WINDOW_MODE.WINDOW);this.ensureDefault("debug",!1);this.settings.debug_enabled=this.settings.debug;
this.settings.return_upload_start_handler=this.returnUploadStart;this.ensureDefault("swfupload_loaded_handler",null);this.ensureDefault("file_dialog_start_handler",null);this.ensureDefault("file_queued_handler",null);this.ensureDefault("file_queue_error_handler",null);this.ensureDefault("file_dialog_complete_handler",null);this.ensureDefault("upload_start_handler",null);this.ensureDefault("upload_progress_handler",null);this.ensureDefault("upload_error_handler",null);this.ensureDefault("upload_success_handler",
null);this.ensureDefault("upload_complete_handler",null);this.ensureDefault("debug_handler",this.debugMessage);this.ensureDefault("custom_settings",{});this.customSettings=this.settings.custom_settings;this.settings.prevent_swf_caching&&(this.settings.flash_url=this.settings.flash_url+(0>this.settings.flash_url.indexOf("?")?"?":"&")+"preventswfcaching="+(new Date).getTime());this.settings.preserve_relative_urls||(this.settings.upload_url=SWFUpload.completeURL(this.settings.upload_url),this.settings.button_image_url=
SWFUpload.completeURL(this.settings.button_image_url));delete this.ensureDefault};
SWFUpload.prototype.loadFlash=function(){var a,b;if(null!==document.getElementById(this.movieName))throw"ID "+this.movieName+" is already in use. The Flash Object could not be added";a=document.getElementById(this.settings.button_placeholder_id)||this.settings.button_placeholder;if(void 0==a)throw"Could not find the placeholder element: "+this.settings.button_placeholder_id;b=document.createElement("div");b.innerHTML=this.getFlashHTML();a.parentNode.replaceChild(b.firstChild,a);void 0==window[this.movieName]&&
(window[this.movieName]=this.getMovieElement())};
SWFUpload.prototype.getFlashHTML=function(){return['<object id="',this.movieName,'" type="application/x-shockwave-flash" data="',this.settings.flash_url,'" width="',this.settings.button_width,'" height="',this.settings.button_height,'" class="swfupload"><param name="wmode" value="','TRANSPARENT','" /><param name="movie" value="',this.settings.flash_url,'" /><param name="quality" value="high" /><param name="menu" value="false" /><param name="allowScriptAccess" value="always" />','<param name="flashvars" value="'+
this.getFlashVars()+'" />',"</object>"].join("")};
SWFUpload.prototype.getFlashVars=function(){var a=this.buildParamString(),b=this.settings.http_success.join(",");return["movieName=",encodeURIComponent(this.movieName),"&amp;uploadURL=",encodeURIComponent(this.settings.upload_url),"&amp;useQueryString=",encodeURIComponent(this.settings.use_query_string),"&amp;requeueOnError=",encodeURIComponent(this.settings.requeue_on_error),"&amp;httpSuccess=",encodeURIComponent(b),"&amp;assumeSuccessTimeout=",encodeURIComponent(this.settings.assume_success_timeout),"&amp;params=",
encodeURIComponent(a),"&amp;filePostName=",encodeURIComponent(this.settings.file_post_name),"&amp;fileTypes=",encodeURIComponent(this.settings.file_types),"&amp;fileTypesDescription=",encodeURIComponent(this.settings.file_types_description),"&amp;fileSizeLimit=",encodeURIComponent(this.settings.file_size_limit),"&amp;fileUploadLimit=",encodeURIComponent(this.settings.file_upload_limit),"&amp;fileQueueLimit=",encodeURIComponent(this.settings.file_queue_limit),"&amp;debugEnabled=",encodeURIComponent(this.settings.debug_enabled),
"&amp;buttonImageURL=",encodeURIComponent(this.settings.button_image_url),"&amp;buttonWidth=",encodeURIComponent(this.settings.button_width),"&amp;buttonHeight=",encodeURIComponent(this.settings.button_height),"&amp;buttonText=",encodeURIComponent(this.settings.button_text),"&amp;buttonTextTopPadding=",encodeURIComponent(this.settings.button_text_top_padding),"&amp;buttonTextLeftPadding=",encodeURIComponent(this.settings.button_text_left_padding),"&amp;buttonTextStyle=",encodeURIComponent(this.settings.button_text_style),
"&amp;buttonAction=",encodeURIComponent(this.settings.button_action),"&amp;buttonDisabled=",encodeURIComponent(this.settings.button_disabled),"&amp;buttonCursor=",encodeURIComponent(this.settings.button_cursor)].join("")};SWFUpload.prototype.getMovieElement=function(){void 0==this.movieElement&&(this.movieElement=document.getElementById(this.movieName));if(null===this.movieElement)throw"Could not find Flash element";return this.movieElement};
SWFUpload.prototype.buildParamString=function(){var a=this.settings.post_params,b=[];if("object"===typeof a)for(var c in a)a.hasOwnProperty(c)&&b.push(encodeURIComponent(c.toString())+"="+encodeURIComponent(a[c].toString()));return b.join("&amp;")};
SWFUpload.prototype.destroy=function(){try{this.cancelUpload(null,!1);var a=null;if((a=this.getMovieElement())&&"unknown"===typeof a.CallFunction){for(var b in a)try{"function"===typeof a[b]&&(a[b]=null)}catch(c){}try{a.parentNode.removeChild(a)}catch(d){}}window[this.movieName]=null;SWFUpload.instances[this.movieName]=null;delete SWFUpload.instances[this.movieName];this.movieName=this.eventQueue=this.customSettings=this.settings=this.movieElement=null;return!0}catch(e){return!1}};
SWFUpload.prototype.displayDebugInfo=function(){this.debug(["---SWFUpload Instance Info---\nVersion: ",SWFUpload.version,"\nMovie Name: ",this.movieName,"\nSettings:\n\tupload_url:               ",this.settings.upload_url,"\n\tflash_url:                ",this.settings.flash_url,"\n\tuse_query_string:         ",this.settings.use_query_string.toString(),"\n\trequeue_on_error:         ",this.settings.requeue_on_error.toString(),"\n\thttp_success:             ",this.settings.http_success.join(", "),"\n\tassume_success_timeout:   ",
this.settings.assume_success_timeout,"\n\tfile_post_name:           ",this.settings.file_post_name,"\n\tpost_params:              ",this.settings.post_params.toString(),"\n\tfile_types:               ",this.settings.file_types,"\n\tfile_types_description:   ",this.settings.file_types_description,"\n\tfile_size_limit:          ",this.settings.file_size_limit,"\n\tfile_upload_limit:        ",this.settings.file_upload_limit,"\n\tfile_queue_limit:         ",this.settings.file_queue_limit,"\n\tdebug:                    ",
this.settings.debug.toString(),"\n\tprevent_swf_caching:      ",this.settings.prevent_swf_caching.toString(),"\n\tbutton_placeholder_id:    ",this.settings.button_placeholder_id.toString(),"\n\tbutton_placeholder:       ",this.settings.button_placeholder?"Set":"Not Set","\n\tbutton_image_url:         ",this.settings.button_image_url.toString(),"\n\tbutton_width:             ",this.settings.button_width.toString(),"\n\tbutton_height:            ",this.settings.button_height.toString(),"\n\tbutton_text:              ",
this.settings.button_text.toString(),"\n\tbutton_text_style:        ",this.settings.button_text_style.toString(),"\n\tbutton_text_top_padding:  ",this.settings.button_text_top_padding.toString(),"\n\tbutton_text_left_padding: ",this.settings.button_text_left_padding.toString(),"\n\tbutton_action:            ",this.settings.button_action.toString(),"\n\tbutton_disabled:          ",this.settings.button_disabled.toString(),"\n\tcustom_settings:          ",this.settings.custom_settings.toString(),"\nEvent Handlers:\n\tswfupload_loaded_handler assigned:  ",
("function"===typeof this.settings.swfupload_loaded_handler).toString(),"\n\tfile_dialog_start_handler assigned: ",("function"===typeof this.settings.file_dialog_start_handler).toString(),"\n\tfile_queued_handler assigned:       ",("function"===typeof this.settings.file_queued_handler).toString(),"\n\tfile_queue_error_handler assigned:  ",("function"===typeof this.settings.file_queue_error_handler).toString(),"\n\tupload_start_handler assigned:      ",("function"===typeof this.settings.upload_start_handler).toString(),
"\n\tupload_progress_handler assigned:   ",("function"===typeof this.settings.upload_progress_handler).toString(),"\n\tupload_error_handler assigned:      ",("function"===typeof this.settings.upload_error_handler).toString(),"\n\tupload_success_handler assigned:    ",("function"===typeof this.settings.upload_success_handler).toString(),"\n\tupload_complete_handler assigned:   ",("function"===typeof this.settings.upload_complete_handler).toString(),"\n\tdebug_handler assigned:             ",("function"===
typeof this.settings.debug_handler).toString(),"\n"].join(""))};SWFUpload.prototype.addSetting=function(a,b,c){return void 0==b?this.settings[a]=c:this.settings[a]=b};SWFUpload.prototype.getSetting=function(a){return void 0!=this.settings[a]?this.settings[a]:""};
SWFUpload.prototype.callFlash=function(a,b){var b=b||[],c=this.getMovieElement(),d,e;try{e=c.CallFunction('<invoke name="'+a+'" returntype="javascript">'+__flash__argumentsToXML(b,0)+"</invoke>"),d=eval(e)}catch(f){throw"Call to "+a+" failed";}void 0!=d&&"object"===typeof d.post&&(d=this.unescapeFilePostParams(d));return d};SWFUpload.prototype.selectFile=function(){this.callFlash("SelectFile")};SWFUpload.prototype.selectFiles=function(){this.callFlash("SelectFiles")};
SWFUpload.prototype.startUpload=function(a){this.callFlash("StartUpload",[a])};SWFUpload.prototype.cancelUpload=function(a,b){!1!==b&&(b=!0);this.callFlash("CancelUpload",[a,b])};SWFUpload.prototype.stopUpload=function(){this.callFlash("StopUpload")};SWFUpload.prototype.getStats=function(){return this.callFlash("GetStats")};SWFUpload.prototype.setStats=function(a){this.callFlash("SetStats",[a])};
SWFUpload.prototype.getFile=function(a){return"number"===typeof a?this.callFlash("GetFileByIndex",[a]):this.callFlash("GetFile",[a])};SWFUpload.prototype.addFileParam=function(a,b,c){return this.callFlash("AddFileParam",[a,b,c])};SWFUpload.prototype.removeFileParam=function(a,b){this.callFlash("RemoveFileParam",[a,b])};SWFUpload.prototype.setUploadURL=function(a){this.settings.upload_url=a.toString();this.callFlash("SetUploadURL",[a])};
SWFUpload.prototype.setPostParams=function(a){this.settings.post_params=a;this.callFlash("SetPostParams",[a])};SWFUpload.prototype.addPostParam=function(a,b){this.settings.post_params[a]=b;this.callFlash("SetPostParams",[this.settings.post_params])};SWFUpload.prototype.removePostParam=function(a){delete this.settings.post_params[a];this.callFlash("SetPostParams",[this.settings.post_params])};
SWFUpload.prototype.setFileTypes=function(a,b){this.settings.file_types=a;this.settings.file_types_description=b;this.callFlash("SetFileTypes",[a,b])};SWFUpload.prototype.setFileSizeLimit=function(a){this.settings.file_size_limit=a;this.callFlash("SetFileSizeLimit",[a])};SWFUpload.prototype.setFileUploadLimit=function(a){this.settings.file_upload_limit=a;this.callFlash("SetFileUploadLimit",[a])};
SWFUpload.prototype.setFileQueueLimit=function(a){this.settings.file_queue_limit=a;this.callFlash("SetFileQueueLimit",[a])};SWFUpload.prototype.setFilePostName=function(a){this.settings.file_post_name=a;this.callFlash("SetFilePostName",[a])};SWFUpload.prototype.setUseQueryString=function(a){this.settings.use_query_string=a;this.callFlash("SetUseQueryString",[a])};SWFUpload.prototype.setRequeueOnError=function(a){this.settings.requeue_on_error=a;this.callFlash("SetRequeueOnError",[a])};
SWFUpload.prototype.setHTTPSuccess=function(a){"string"===typeof a&&(a=a.replace(" ","").split(","));this.settings.http_success=a;this.callFlash("SetHTTPSuccess",[a])};SWFUpload.prototype.setAssumeSuccessTimeout=function(a){this.settings.assume_success_timeout=a;this.callFlash("SetAssumeSuccessTimeout",[a])};SWFUpload.prototype.setDebugEnabled=function(a){this.settings.debug_enabled=a;this.callFlash("SetDebugEnabled",[a])};
SWFUpload.prototype.setButtonImageURL=function(a){void 0==a&&(a="");this.settings.button_image_url=a;this.callFlash("SetButtonImageURL",[a])};SWFUpload.prototype.setButtonDimensions=function(a,b){this.settings.button_width=a;this.settings.button_height=b;var c=this.getMovieElement();void 0!=c&&(c.style.width=a+"px",c.style.height=b+"px");this.callFlash("SetButtonDimensions",[a,b])};SWFUpload.prototype.setButtonText=function(a){this.settings.button_text=a;this.callFlash("SetButtonText",[a])};
SWFUpload.prototype.setButtonTextPadding=function(a,b){this.settings.button_text_top_padding=b;this.settings.button_text_left_padding=a;this.callFlash("SetButtonTextPadding",[a,b])};SWFUpload.prototype.setButtonTextStyle=function(a){this.settings.button_text_style=a;this.callFlash("SetButtonTextStyle",[a])};SWFUpload.prototype.setButtonDisabled=function(a){this.settings.button_disabled=a;this.callFlash("SetButtonDisabled",[a])};
SWFUpload.prototype.setButtonAction=function(a){this.settings.button_action=a;this.callFlash("SetButtonAction",[a])};SWFUpload.prototype.setButtonCursor=function(a){this.settings.button_cursor=a;this.callFlash("SetButtonCursor",[a])};
SWFUpload.prototype.queueEvent=function(a,b){void 0==b?b=[]:b instanceof Array||(b=[b]);var c=this;if("function"===typeof this.settings[a])this.eventQueue.push(function(){this.settings[a].apply(this,b)}),setTimeout(function(){c.executeNextEvent()},0);else if(null!==this.settings[a])throw"Event handler "+a+" is unknown or is not a function";};SWFUpload.prototype.executeNextEvent=function(){var a=this.eventQueue?this.eventQueue.shift():null;"function"===typeof a&&a.apply(this)};
SWFUpload.prototype.unescapeFilePostParams=function(a){var b=/[$]([0-9a-f]{4})/i,c={},d;if(void 0!=a){for(var e in a.post)if(a.post.hasOwnProperty(e)){d=e;for(var f;null!==(f=b.exec(d));)d=d.replace(f[0],String.fromCharCode(parseInt("0x"+f[1],16)));c[d]=a.post[e]}a.post=c}return a};SWFUpload.prototype.testExternalInterface=function(){try{return this.callFlash("TestExternalInterface")}catch(a){return!1}};
SWFUpload.prototype.flashReady=function(){var a=this.getMovieElement();a?(this.cleanUp(a),this.queueEvent("swfupload_loaded_handler")):this.debug("Flash called back ready but the flash movie can't be found.")};
SWFUpload.prototype.cleanUp=function(a){try{if(this.movieElement&&"unknown"===typeof a.CallFunction){this.debug("Removing Flash functions hooks (this should only run in IE and should prevent memory leaks)");for(var b in a)try{"function"===typeof a[b]&&(a[b]=null)}catch(c){}}}catch(d){}window.__flash__removeCallback=function(a,b){try{a&&(a[b]=null)}catch(c){}}};SWFUpload.prototype.fileDialogStart=function(){this.queueEvent("file_dialog_start_handler")};
SWFUpload.prototype.fileQueued=function(a){a=this.unescapeFilePostParams(a);this.queueEvent("file_queued_handler",a)};SWFUpload.prototype.fileQueueError=function(a,b,c){a=this.unescapeFilePostParams(a);this.queueEvent("file_queue_error_handler",[a,b,c])};SWFUpload.prototype.fileDialogComplete=function(a,b,c){this.queueEvent("file_dialog_complete_handler",[a,b,c])};SWFUpload.prototype.uploadStart=function(a){a=this.unescapeFilePostParams(a);this.queueEvent("return_upload_start_handler",a)};
SWFUpload.prototype.returnUploadStart=function(a){var b;if("function"===typeof this.settings.upload_start_handler)a=this.unescapeFilePostParams(a),b=this.settings.upload_start_handler.call(this,a);else if(void 0!=this.settings.upload_start_handler)throw"upload_start_handler must be a function";void 0===b&&(b=!0);this.callFlash("ReturnUploadStart",[!!b])};SWFUpload.prototype.uploadProgress=function(a,b,c){a=this.unescapeFilePostParams(a);this.queueEvent("upload_progress_handler",[a,b,c])};
SWFUpload.prototype.uploadError=function(a,b,c){a=this.unescapeFilePostParams(a);this.queueEvent("upload_error_handler",[a,b,c])};SWFUpload.prototype.uploadSuccess=function(a,b,c){a=this.unescapeFilePostParams(a);this.queueEvent("upload_success_handler",[a,b,c])};SWFUpload.prototype.uploadComplete=function(a){a=this.unescapeFilePostParams(a);this.queueEvent("upload_complete_handler",a)};SWFUpload.prototype.debug=function(a){this.queueEvent("debug_handler",a)};
SWFUpload.prototype.debugMessage=function(a){if(this.settings.debug){var b=[];if("object"===typeof a&&"string"===typeof a.name&&"string"===typeof a.message){for(var c in a)a.hasOwnProperty(c)&&b.push(c+": "+a[c]);a=b.join("\n")||"";b=a.split("\n");a="EXCEPTION: "+b.join("\nEXCEPTION: ")}SWFUpload.Console.writeLine(a)}};SWFUpload.Console={};
SWFUpload.Console.writeLine=function(a){var b,c;try{b=document.getElementById("SWFUpload_Console"),b||(c=document.createElement("form"),document.getElementsByTagName("body")[0].appendChild(c),b=document.createElement("textarea"),b.id="SWFUpload_Console",b.style.fontFamily="monospace",b.setAttribute("wrap","off"),b.wrap="off",b.style.overflow="auto",b.style.width="700px",b.style.height="350px",b.style.margin="5px",c.appendChild(b)),b.value+=a+"\n",b.scrollTop=b.scrollHeight-b.clientHeight}catch(d){alert("Exception: "+
d.name+" Message: "+d.message)}};



/*---------------------------------------------  延迟加载图片plugin -------------------------------------------------------------- */
(function($){$.fn.lazyload=function(options){var settings={threshold:0,failurelimit:0,event:"scroll",effect:"show",container:window};if(options){$.extend(settings,options);}
var elements=this;if("scroll"==settings.event){$(settings.container).bind("scroll",function(event){var counter=0;elements.each(function(){if($.abovethetop(this,settings)||$.leftofbegin(this,settings)){}else if(!$.belowthefold(this,settings)&&!$.rightoffold(this,settings)){$(this).trigger("appear");}else{if(counter++>settings.failurelimit){return false;}}});var temp=$.grep(elements,function(element){return!element.loaded;});elements=$(temp);});}
this.each(function(){var self=this;if(undefined==$(self).attr("original")){$(self).attr("original",$(self).attr("src"));}
if("scroll"!=settings.event||undefined==$(self).attr("src")||settings.placeholder==$(self).attr("src")||($.abovethetop(self,settings)||$.leftofbegin(self,settings)||$.belowthefold(self,settings)||$.rightoffold(self,settings))){if(settings.placeholder){$(self).attr("src",settings.placeholder);}else{$(self).removeAttr("src");}
self.loaded=false;}else{self.loaded=true;}
$(self).one("appear",function(){if(!this.loaded){$("<img />").bind("load",function(){$(self).hide().attr("src",$(self).attr("original"))
[settings.effect](settings.effectspeed);self.loaded=true;}).attr("src",$(self).attr("original"));};});if("scroll"!=settings.event){$(self).bind(settings.event,function(event){if(!self.loaded){$(self).trigger("appear");}});}});$(settings.container).trigger(settings.event);return this;};$.belowthefold=function(element,settings){if(settings.container===undefined||settings.container===window){var fold=$(window).height()+$(window).scrollTop();}else{var fold=$(settings.container).offset().top+$(settings.container).height();}
return fold<=$(element).offset().top-settings.threshold;};$.rightoffold=function(element,settings){if(settings.container===undefined||settings.container===window){var fold=$(window).width()+$(window).scrollLeft();}else{var fold=$(settings.container).offset().left+$(settings.container).width();}
return fold<=$(element).offset().left-settings.threshold;};$.abovethetop=function(element,settings){if(settings.container===undefined||settings.container===window){var fold=$(window).scrollTop();}else{var fold=$(settings.container).offset().top;}
return fold>=$(element).offset().top+settings.threshold+$(element).height();};$.leftofbegin=function(element,settings){if(settings.container===undefined||settings.container===window){var fold=$(window).scrollLeft();}else{var fold=$(settings.container).offset().left;}
return fold>=$(element).offset().left+settings.threshold+$(element).width();};$.extend($.expr[':'],{"below-the-fold":"$.belowthefold(a, {threshold : 0, container: window})","above-the-fold":"!$.belowthefold(a, {threshold : 0, container: window})","right-of-fold":"$.rightoffold(a, {threshold : 0, container: window})","left-of-fold":"!$.rightoffold(a, {threshold : 0, container: window})"});})(jQuery);
