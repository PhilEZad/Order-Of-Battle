import {AfterViewInit, Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-stratagem',
  templateUrl: './stratagem.component.html',
  styleUrls: ['./stratagem.component.scss']
})
export class StratagemComponent implements OnInit, AfterViewInit {

  title = 'BREACH AND CLEAR'
  subtitle = 'T’au Empire – Battle Tactic Stratagem'
  cp = '1CP/2CP'
  flavourText = 'Breacher Teams excel at clearing enemy-held structures with blinding photon grenades and disciplined bursts of pulse fire.'
  descriptionTop = 'Use this Stratagem in your Shooting phase, when a BREACHER TEAM unit from your army is selected to shoot. Until the end of the phase, each time a CORE model in that unit makes a ranged attack:'
  descriptionBottom = ''
  list: any[] = ['The target does not receive the benefits of cover against that attack.', 'You can re-roll the wound roll.'];
  color = 'requisition'

  constructor() {
  }

  ngOnInit(): void {
    this.setHeaderColor(this.color);
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
      }
    } else
    {

    }
  }
}
