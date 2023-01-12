import Calendar from '@toast-ui/calendar';
import '@toast-ui/calendar/dist/toastui-calendar.min.css';

(function($){
  var cal = $("#calendar");
  var calendarControl = cal.closest(".ssar-calendar");

  var calendar = new Calendar("#calendar", {
    defaultView: 'month',
    calendars: [{
      id: 1,
      name: 'My Calendar'
    }],
    useFormPopup: true,
    useDetailPopup: true
  });

  fetch('https://localhost:7261/calendarevent')
    .then(response => {
      return response.json();
    })
    .then(events => {
      calendar.createEvents(events);
    })

  var prev = calendarControl.find(".prev");
  prev.on("click", function(e){
    calendar.prev();
    updateTitle(e);
  });

  var next = calendarControl.find(".next");
  next.on("click", function(e){
    calendar.next();
    updateTitle(e);
  });

  var title = calendarControl.find(".title");
  updateTitle();
  function updateTitle(event){
    title.text(calendar.getDate());
  };

})($)