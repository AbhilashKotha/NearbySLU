import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewplacaddComponent } from './newplacadd.component';

describe('NewplacaddComponent', () => {
  let component: NewplacaddComponent;
  let fixture: ComponentFixture<NewplacaddComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewplacaddComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewplacaddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
