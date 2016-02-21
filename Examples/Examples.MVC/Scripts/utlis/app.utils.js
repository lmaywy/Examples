window.app=window.app || {};
window.app.utils=window.app.utils||{};

/**
 * slice a display text with given "..."+a suffix in an known container and targetWidth
 * if the text width is less than targetWidth,then display text should be text+suffix
 * else slice the text until the width is less than targetWidth, then display text should be text +"..."+suffix
 * @param {} $targetContainers 
 * @param {} targetWidth 
 * @returns {} 
 */
window.app.utils.sliceStringWithSuffix = function ($targetContainers,targetWidth) {
  var name = "",
    suffix = "",
    endIndex = 0,
    originalWidth = 0,
    $copyContainer = $('<label></label>').css('display', 'none').appendTo("body");

  $targetContainers.each(function() {
    suffix = $(this).data("unit-currency");
    name = $(this).data("full-name");
    $copyContainer.text(name + suffix);
    originalWidth = $copyContainer.width();
    endIndex = name.length - 1;

    if (originalWidth >= targetWidth) {
      suffix = "..." + suffix;
      while (originalWidth >= targetWidth) {
        name = name.substring(0, endIndex);
        originalWidth = $copyContainer.text(name + suffix).width();
        endIndex = endIndex - 1;
      }
    }
    $(this).find("label").text(name + suffix);
  });

  $copyContainer.remove();
}