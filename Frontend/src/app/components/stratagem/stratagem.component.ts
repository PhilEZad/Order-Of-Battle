import { AfterViewInit, Component, Input, OnInit} from '@angular/core';
import { Stratagem } from "../../interfaces/Stratagem";

@Component({
  selector: 'app-stratagem',
  templateUrl: './stratagem.component.html',
  styleUrls: ['./stratagem.component.scss']
})
export class StratagemComponent implements OnInit, AfterViewInit {
  @Input() selectedStratagem?: Stratagem;

  constructor() {

  }

  ngOnInit(): void {

  }

  ngAfterViewInit() {
  }
}
