import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StartGridComponent } from './start-grid.component';

describe('StartGridComponent', () => {
  let component: StartGridComponent;
  let fixture: ComponentFixture<StartGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StartGridComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StartGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
