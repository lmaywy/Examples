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
  });
}(jQuery))