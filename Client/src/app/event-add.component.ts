import { Component } from '@angular/core';
import { EventService } from './event.service';

@Component({
  selector: 'app-event-add',
  template: `
    <div>
      <input [(ngModel)]="newEvent.name" placeholder="Event Name" />
      <input [(ngModel)]="newEvent.date" placeholder="Event Date" type="date" />
      <button (click)="addEvent()">Add Event</button>
    </div>
  `,
})
export class EventAddComponent {
  newEvent: Event = { name: '', date: '' }; 

  constructor(private eventService: EventService) {}

  addEvent() {
    this.eventService.addEvent(this.newEvent).subscribe((event) => {
      console.log('Event added:', event);
    });
  }
}
