import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SerieFichaComponent } from './serie-ficha.component';

describe('SerieFichaComponent', () => {
  let component: SerieFichaComponent;
  let fixture: ComponentFixture<SerieFichaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SerieFichaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SerieFichaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
