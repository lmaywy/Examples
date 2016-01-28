(function ($) {
  module("HelloWorldWidget Module", {
    setup: function () {

    },
    teardown: function () {

    }
  });

  test("_create: when the widget is created, the element should contains the given class name ", 1, function () {
    //mock
    var className = "Red";
    var mockThis = {
      options: {
        className: className
      },
      element: $("<div>")
    };

    //act
    $.ui.helloWorld.prototype._create.call(mockThis);

    // assert
    ok(mockThis.element.hasClass(className), "the widget element contains the class name:" + className);

    //ok(true, "true succeeds");
    //ok("non-empty", "non-empty string succeeds");
    //ok(false, "false fails");
    //ok(0, "0 fails");
    //ok(NaN, "NaN fails");
    //ok("", "empty string fails");
    //ok(null, "null fails");
    //ok(undefined, "undefined fails");
  });

  test("_destroy:when the widget destroyed, the elemnt should not contains the given class name", 1, function (assert) {
    //mock
    var className = "Red";
    var mockThis = {
      options: {
        className: className
      },
      element: $("<div>")
    };

    $.ui.helloWorld.prototype._destroy.call(mockThis);

    equal(mockThis.element.hasClass(className), false, "the elemnt not contains the given class name");
  });
}(jQuery))