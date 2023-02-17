import { Component, OnInit } from '@angular/core';
import { Stratagem } from "../../interfaces/Stratagem";
import { StratagemService } from "../../services/stratagem.service";


@Component({
  selector: 'app-start-grid',
  templateUrl: './start-grid.component.html',
  styleUrls: ['./start-grid.component.scss']
})
export class StartGridComponent implements OnInit {
  stratList: Stratagem[] = []
  constructor(private stratagemService: StratagemService)
  {

  }

  ngOnInit(): void {
    this.getStratagems();
    console.log(this.stratList)
  }

  getStratagems(): void
  {
    this.stratList = this.stratagemService.getStratagems();
  }
}
