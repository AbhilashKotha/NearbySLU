import { TestBed } from '@angular/core/testing';

import { NewplacaddService } from './newplacadd.service';

describe('NewplacaddService', () => {
  let service: NewplacaddService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(NewplacaddService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
