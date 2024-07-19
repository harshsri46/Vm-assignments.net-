import { Component } from '@angular/core';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent {
  employees = [
    { firstName: 'harsh', country: 'UK', salary: 8000},
    { firstName: 'rohit', country: 'India', salary: 3000},
    { firstName: 'gaurav', country: 'UK', salary: 90000},
    { firstName: 'kartik', country: 'Australia', salary: 2000 }
  ];
}
