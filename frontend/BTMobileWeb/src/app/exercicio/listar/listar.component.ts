import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ExercicioService } from 'src/app/exercicio.service';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrls: ['./listar.component.css']
})
export class Exercicio_Listar implements OnInit {

  public exercicios: Array<any>;

  constructor(private rt: Router, private exercicioService: ExercicioService) {
    this.exercicioService.listar().subscribe((data: any) => this.exercicios = data);
   };

  ngOnInit() {
  }

  public incluir = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['/exercicio', 0]);
  };

  public excluir = function(event: Event, exercicioId: number) {
    event.preventDefault();
    event.stopPropagation();

    let confirmou = confirm("Deseja excluir o exercicio?");

    if (confirmou) {
      this.exercicioService.excluir(exercicioId).subscribe((data: any) => {
        window.location.reload();
      });
    }
  };

}
