import Calendar from '@toast-ui/calendar';
import '@toast-ui/calendar/dist/toastui-calendar.min.css';

const calendar = new Calendar('#calendar', {
    defaultView: 'week',
    template: {
      time(event) {
        const { start, end, title } = event;
  
        return `<span style="color: white;">${formatTime(start)}~${formatTime(end)} ${title}</span>`;
      },
      allday(event) {
        return `<span style="color: gray;">${event.title}</span>`;
      },
    },
    calendars: [
      {
        id: 'cal1',
        name: 'Personal',
        backgroundColor: '#03bd9e',
      },
      {
        id: 'cal2',
        name: 'Work',
        backgroundColor: '#00a9ff',
      },
    ],
  });