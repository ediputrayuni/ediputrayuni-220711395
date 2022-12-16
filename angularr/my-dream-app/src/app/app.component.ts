import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  matakuliah = 'Pemprograman Framework'

  GantiMataKuliah()
  {
    this.matakuliah = 'Pemprograman Visual'
  }
}