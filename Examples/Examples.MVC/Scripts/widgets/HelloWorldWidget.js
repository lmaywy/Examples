(function ($) {
  /*
 jQuery.widget( name [, base ], prototype )
 Paras:
    name
    Type: String
    The name of the widget to create, including the namespace.
    base
    Type: Function()
    The base widget to inherit from. This must be a constructor that can be instantiated with the `new` keyword. Defaults to jQuery.Widget.
    prototype
    Type: PlainObject
    The object to use as a prototype for the widget.
   */
  $.widget("ui.helloWorld", {
    options: {
      className: "red"
    },
    _create:function() {
      var that = this;
      that.element.addClass(that.options.className);
    },
    _destroy:function() {
      var that = this;
      if (that.element.hasClass(that.options.className)) {
        that.element.removeClass(that.options.className);
      }
    }
  });

})(jQuery)