$(document).ready(function () {

	$(function () {

		jQuery.validator.addMethod('validbirthdate', function (value, element, params) {
			var currentDate = new Date();
			if (Date.parse(value) > currentDate) {
				return false;
			}
			return true;
		}, '');

		jQuery.validator.unobtrusive.adapters.add('validbirthdate', function (options) {
			options.rules['validbirthdate'] = {};
			options.messages['validbirthdate'] = options.message;
		});

	}(jQuery));

	//$.validator.methods.date = function (value, element) {
	//	return this.optional(element) || Globalize.parseDate(value, "dd/MM/yyyy", "ru-RU");
	//}

	$("#PhoneNumber").keydown(function (e) {
		// Allow: backspace, delete, tab, escape, enter and .
		if ($.inArray(e.keyCode, [46, 8, 9, 27, 13, 110, 190]) !== -1 ||
			// Allow: Ctrl+A, Command+A
			(e.keyCode === 65 && (e.ctrlKey === true || e.metaKey === true)) ||
			// Allow: home, end, left, right, down, up
			(e.keyCode >= 35 && e.keyCode <= 40)) {
			// let it happen, don't do anything
			return;
		}
		// Ensure that it is a number and stop the keypress
		if ((e.shiftKey || (e.keyCode < 48 || e.keyCode > 57)) && (e.keyCode < 96 || e.keyCode > 105)) {
			e.preventDefault();
		}
	});

	// TODO: DO NOT HIDE FORCE !

	$("#Employed").prop('checked', false);

	$(".organiz").hide();

	$("#Employed").change(function () {
		if (this.checked) {
			$(".organiz").show();
			$(".organiz").attr('data-val', 'true');
		} else {
			$(".organiz").hide();
			$(".organiz").attr('data-val', 'false');
		}
	});

});