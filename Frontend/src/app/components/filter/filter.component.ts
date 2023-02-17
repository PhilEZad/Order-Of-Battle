import {Component, OnInit, Input, Output, EventEmitter} from '@angular/core';

@Component({
  selector: 'app-filter',
  templateUrl: './filter.component.html',
  styleUrls: ['./filter.component.scss']
})
export class FilterComponent implements OnInit {

  selectedFilterValue: string = 'Command';

  constructor() { }

  ngOnInit(): void {
  }

  @Output()
  filterSelectionEvent: EventEmitter<string> = new EventEmitter<string>();

  onFilterButtonSelection()
  {
    this.filterSelectionEvent.emit(this.selectedFilterValue);
    console.log(this.selectedFilterValue)
  }
}
