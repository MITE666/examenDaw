// app.component.ts
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <h1>
      Welcome to {{ title }}!
    </h1>
    <app-event-list></app-event-list>
    <app-event-add></app-event-add>
  `,
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'Your App';
}
