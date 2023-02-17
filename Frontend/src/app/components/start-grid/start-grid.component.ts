import { Component, OnInit } from '@angular/core';
import { Stratagem } from "../../interfaces/Stratagem";
import { StratagemService } from "../../services/stratagem.service";
import {countOccurrences} from "@angular-devkit/build-angular/src/webpack/plugins/analytics";


@Component({
  selector: 'app-start-grid',
  templateUrl: './start-grid.component.html',
  styleUrls: ['./start-grid.component.scss']
})
export class StartGridComponent implements OnInit {
  stratList: Stratagem[] = []
  selectedFilterButton: string = 'Movement'
  constructor(private stratagemService: StratagemService)
  {

  }

  ngOnInit(): void {
    this.getStratagems();
  }

  getStratagems(): void
  {
    this.stratList = this.stratagemService.getStratagems();
  }

  onFilterButtonPressed(data: string)
  {
    this.selectedFilterButton = data;
  }
}
