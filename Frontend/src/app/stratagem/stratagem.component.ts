import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-stratagem',
  templateUrl: './stratagem.component.html',
  styleUrls: ['./stratagem.component.scss']
})
export class StratagemComponent implements OnInit {

  title = 'BREACH AND CLEAR'
  subtitle = 'T’au Empire – Battle Tactic Stratagem'
  cp = '1CP/2CP'
  flavourText = 'Breacher Teams excel at clearing enemy-held structures with blinding photon grenades and disciplined bursts of pulse fire.'
  descriptionTop = 'Use this Stratagem in your Shooting phase, when a BREACHER TEAM unit from your army is selected to shoot. Until the end of the phase, each time a CORE model in that unit makes a ranged attack:'
  descriptionBottom = ''
  list: any[] = ['The target does not receive the benefits of cover against that attack.', 'You can re-roll the wound roll.'];
  constructor() { }

  ngOnInit(): void {
    this.ngAfterViewInit()
  }

  ngAfterViewInit() {
    document.getElementsByClassName('mat-card-header-text')[0].setAttribute('style', 'margin: 0 0');
  }

}
