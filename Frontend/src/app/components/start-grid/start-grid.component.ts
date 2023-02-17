import { Component, OnInit } from '@angular/core';
import { Stratagem } from "../../interfaces/Stratagem";


@Component({
  selector: 'app-start-grid',
  templateUrl: './start-grid.component.html',
  styleUrls: ['./start-grid.component.scss']
})
export class StartGridComponent implements OnInit {

  stratList: Stratagem[] = []
  constructor() { }

  ngOnInit(): void {
  }
}
