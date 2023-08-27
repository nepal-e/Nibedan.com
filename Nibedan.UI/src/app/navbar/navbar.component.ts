import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent {
  constructor(private http: Http) {}

  getFormsTitles() {}
}
