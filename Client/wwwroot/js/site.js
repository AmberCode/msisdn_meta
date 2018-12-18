$(function () {
    const d = new Date();

    $('#fromDate').val(d.toLocaleDateString('lt-LT'));
    $('#toDate').val(d.toLocaleDateString('lt-LT'));

    $('.datepicker').datepicker({
        autoclose: true,
        format: 'yyyy-mm-dd',
        startDate: '2012-01-01',
        language: 'lt'
    });

    $('#filterButton').click((e) => {
        const fromDate = $('#fromDate').val();
        const toDate = $('#toDate').val();

        filter(fromDate, toDate);
    });

    const filter = (fromDate, toDate) => {
        $.ajax({
            url: "/Home/Filter",
            type: "GET",
            data: {
                FromDate: fromDate,
                ToDate: toDate
            },
            success: function (response) {
                $("#topSmsList").empty();
                $("#topCallList").empty();
                
                $('#smsCountLabel').text(response.countBySms);
                $('#callCountLabel').text(response.countByCall);

                response.top5BySms.forEach((item) => {
                    $("#topSmsList").append($("<li>").text(item.number));
                });

                response.top5ByCall.forEach((item) => {
                    $("#topCallList").append($("<li>").text(item.number));
                });
            },
            error: function (xhr) {
                console.log("error");
                //TODO: handle non OK response
            }
        });
    };
});
