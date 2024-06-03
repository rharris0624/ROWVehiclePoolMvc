function formatEmailAddress() {
    if ($("#RequestFirstName").val())
        if ($("#RequestLastName").val())
            $("#EmailAddress").val($("#RequestFirstName").val() + "." + $("#RequestLastName").val() + "@ardot.gov");
        else
            $("#EmailAddress").val($("#RequestFirstName").val() + ".@ardot.gov");
    else
        if ($("#RequestLastName").val())
            $("#EmailAddress").val($("#RequestLastName") + ".@ardot.gov");
        else
            $("#EmailAddress").val("@ardot.gov");
}

function upperCase(strElement) {
    strElement.value = strElement.value.toUpperCase()
}

$(document).ready(function () {

    $.validator.addMethod("validReturnDate", function (value, element) {
        var date1 = new Date(value.substring(0, 10) + "T" + $("#ReturnTime").val());
        var date2 = new Date($("#DepartDate").val().substring(0, 10) + "T" + $("#DepartTime").val());
        return date1.getTime() > date2.getTime();
    }, "Please enter a valid return date");

    });

(function ($) {
    var placeHolder = $('')
    $('#ReqBudget').val("120");
    $('#ReqJobNo').val('0810');
    $('button[data-toggle="ajax-modal"]').click(
        function (event) {
            event.stopPropagation();
            var url = $(this).data('url');
        }
    );
    function Index() {
        var $this = this;
        function initialize() {

            $(".popup").on('click', function (e) {
                modelPopup(this);
            });

            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {
                    //debugger;
                    $('#modal-select-job-function').find(".modal-dialog").html(data);
                    $('#modal-select-job-function > .modal', data).modal("show");
                });

            }
        }

        $this.init = function () {
            initialize();
        };
    }
    $(function () {
        var self = new Index();
        self.init();
    });
    var getData = function (request, response) {
        $.getJSON(
            "http://gd.geobytes.com/AutoCompleteCity?callback=?&q=" + request.term,
            function (data) {
                response(data);
            });
    };

    var selectItem = function (event, ui) {
        $("#myText").val(ui.item.value);
        return false;
    };

    $("#ReqJobNo").autocomplete({
        source: getData,
        select: selectItem,
        minLength: 4,
        change: function () {
            $("#myText").val("").css("display", 2);
        }
    });
    function updatebox() {
        var formObj = document.getElementById("f1");
        fillday(formObj, f1.mnt.value, f1.day.value, f1.yr.value);
    }

    function getDaysInMonth(mnth, yr) {
        var retdays = 31;
        if (mnth === 4 || mnth === 6 || mnth === 9 || mnth === 11) {
            retdays = 30;
        } else if (mnth === 2) {
            if ((yr % 100) === 0 || (yr % 4) > 0) {
                retdays = 28;
            }
            else {
                retdays = 29;
            }
        }

        return retdays;
    };
}(jQuery));
