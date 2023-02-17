import { TestBed } from '@angular/core/testing';

import { StratagemService } from './stratagem.service';

describe('StratagemService', () => {
  let service: StratagemService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StratagemService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
