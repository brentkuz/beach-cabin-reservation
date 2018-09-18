
(function ($, util, moment) {
    var name = "Index";
    util.CheckDependencies(name, arguments); 

    $(function () {              

        $("#calendar").fullCalendar({
            defaultView: "month",
            header: {
                left: 'title',
                center: 'addEvent',
                right: 'agendaWeek,month today prev,next'
            },
            events: [
                {
                    title: "event 1",
                    start: "2018-09-25",
                    allDay: true,
                    backgroundColor: "green"
                },
                {
                    title: "event 2",
                    start: "2018-09-18T10:00:00",
                    end: "2018-09-20T12:00:00"
                }
            ],
            customButtons: {
                addEvent: {
                    text: "New Reservation",
                    click: function () {
                        alert("reserving")
                    }
                }
            },
            dayClick: function (day, jsEvent, view) {
                if (view.name == "month") {
                    $("#calendar").fullCalendar('changeView', 'agendaWeek');
                }
                $("#calendar").fullCalendar("gotoDate", day);
            },
            eventClick: function (event, jsEvent, view) {
                alert("clicked event")
            },

        })

    });



})(jQuery, window.App.Utility, moment);