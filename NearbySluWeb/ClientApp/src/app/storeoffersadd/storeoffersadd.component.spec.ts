import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StoreoffersaddComponent } from './storeoffersadd.component';

describe('StoreoffersaddComponent', () => {
  let component: StoreoffersaddComponent;
  let fixture: ComponentFixture<StoreoffersaddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StoreoffersaddComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StoreoffersaddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
