import { TestBed } from '@angular/core/testing';

import { StoreoffersaddService } from './storeoffersadd.service';

describe('StoreoffersaddService', () => {
  let service: StoreoffersaddService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StoreoffersaddService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
