import { Component, OnInit } from '@angular/core';
import { FichaService } from 'src/app/ficha.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-exercicio-serie',
  templateUrl: './exercicio-serie.component.html',
  styleUrls: ['./exercicio-serie.component.css']
})
export class Ficha_ExercicioSerie implements OnInit {

  public fichaId: number;
  public serieFichaId: number;
  public exercicios: Array<any>;
  public repeticao: string = "";
  public carga: any = "";

  public exercicioIdSelecionado: number;

  constructor(private route: ActivatedRoute, private fichaService: FichaService, private rt: Router) { 
    this.route.params.subscribe(params => {
      if (params.fichaId) this.fichaId = params.fichaId;
      if (params.serieFichaId) this.serieFichaId = params.serieFichaId;
    });
    fichaService.getExercicios().subscribe((data: any) => this.exercicios = data);
  }

  ngOnInit() {
  }

  public setExercicioId = function(exercicioId: number) {
    this.exercicioIdSelecionado = exercicioId;
  }

  public salvarExercicioSerie = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.fichaService.adicionarExercicioSerie(this.serieFichaId, this.exercicioIdSelecionado, this.repeticao, this.carga,
      () => {
        this.rt.navigate(['/ficha', this.fichaId]);
      })
  }

}
