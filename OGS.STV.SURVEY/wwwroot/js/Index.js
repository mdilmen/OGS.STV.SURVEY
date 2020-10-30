$(document).ready(function () {
    // Hesapla Buttom 
    $("#btnCalculate").attr('disabled', true);

    // DatePicker
    $(".datepicker").datepicker({
        changeMonth: true,
        changeYear: true,
        format: "dd.mm.yyyy",
        language: "tr",
        todayHighlight: "true",
        autoclose: "true"
    });


    
    //console.log(isshow);
    var noLogModalShown = sessionStorage.getItem("noLogModalShown");
    if (noLogModalShown == null) {
        $('#noLogModal').modal('show');
        sessionStorage.setItem("noLogModalShown", "true");
    };
    // read Modal 
    $("#readCheck").change(function () {
        //if ($("#readCheck").is(':checked') == true) { $('#readModal').modal("show");}        
        toggleCalculateButton();
    }
    );
    // approve Modal
    $("#approveCheck").change(function () {
        toggleCalculateButton();
    }
    );
    // approve Modal
    $("#approveEmailCheck").change(function () {
        toggleCalculateButton();
    }
    );
});
function toggleCalculateButton() {
    //console.log("readCheck " + $("#readCheck").is(':checked'));
    //console.log("approveCheck " + $("#approveCheck").is(':checked'));
    if ($("#readCheck").is(':checked') && $("#approveCheck").is(':checked') && $("#approveEmailCheck").is(':checked')) {
        $("#btnCalculate").attr('disabled', false);
    }
    else {
        $("#btnCalculate").attr('disabled', true);
    }
}
window.onbeforeunload = function () { localStorage.clear(); };