import { TestBed, inject } from '@angular/core/testing';

import { ExercicioService } from './exercicio.service';

describe('ExercicioService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ExercicioService]
    });
  });

  it('should be created', inject([ExercicioService], (service: ExercicioService) => {
    expect(service).toBeTruthy();
  }));
});
