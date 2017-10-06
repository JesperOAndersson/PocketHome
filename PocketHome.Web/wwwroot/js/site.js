// Write your Javascript code.
$(".button-outline").click(function () {
	var turn = 0;
	if ($(this).hasClass("button-off")) {
		$(this).removeClass("button-off");
		$(this).addClass("button-on");
		$(this).children("p").first().text = "on";
		turn = 1;
	} else {
		$(this).removeClass("button-on");
		$(this).addClass("button-off");
		$(this).children("p").first().text = "off";
	}
	$.ajax({
		type: "POST",
		url: "/device/togglelight?id=" + $(this).data("device") + "&toggle=" + turn,
		datatype: "html",
		success: function (data) {
			$('#result').html(data);
		}
	});
});
