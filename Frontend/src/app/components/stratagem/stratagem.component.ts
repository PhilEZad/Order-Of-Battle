import {AfterViewInit, Component, Input, OnInit} from '@angular/core';
import { Stratagem } from "../../interfaces/Stratagem";

@Component({
  selector: 'app-stratagem',
  templateUrl: './stratagem.component.html',
  styleUrls: ['./stratagem.component.scss']
})
export class StratagemComponent implements OnInit, AfterViewInit {
  @Input() stratagem?: Stratagem;

  constructor() {
  }

  ngOnInit(): void {
  }

  ngAfterViewInit() {
    document.getElementsByClassName('mat-card-header-text')[0].setAttribute('style', 'margin: 0 0');
  }

  setHeaderColor(color: string): void {
    let header = document.getElementById("testid");

    if (header != null) {
      switch (color) {
        case 'tactic':
        {
          header.style.backgroundColor = '#304c64';
          break;
        }
        case 'ploy': {
          header.style.backgroundColor = '#246656';
          break;
        }
        case 'epic': {
          header.style.backgroundColor = '#683c2c';
          break;
        }
        case 'requisition':
        {
          header.style.backgroundColor = '#c0241c';
          break;
        }
        case 'wargear':
        {
          header.style.backgroundColor = '#60686a';
          break;
        }
        default:
        {
          header.style.backgroundColor = 'yellow'
          break;
        }
      }
    }
  }
}
