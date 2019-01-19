import { FichaService } from './../../ficha.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-alterar-carga',
  templateUrl: './alterar-carga.component.html',
  styleUrls: ['./alterar-carga.component.css']
})

export class Ficha_AlterarCarga implements OnInit {

  public fichaId: number;
  public clienteId: number;
  public exercicioSerieId: number;
  public nomeExercicio: string;
  public valorCarga: number;
  public novaCarga: any = "";

  constructor(private route: ActivatedRoute, private fichaService: FichaService, private rt: Router) { 
    this.route.params.subscribe(params => {
      if (params.fichaId) this.fichaId = params.fichaId;
      if (params.clienteId) this.clienteId = params.clienteId;
      if (params.exercicioSerieId) this.exercicioSerieId = params.exercicioSerieId;
      if (params.nomeExercicio) this.nomeExercicio = params.nomeExercicio;
      if (params.valorCarga) this.valorCarga = params.valorCarga;
    });
  }
  
  ngOnInit() {
  }

  public salvarNovaCarga = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.fichaService.alterarCarga(this.fichaId, this.clienteId, this.exercicioSerieId, this.novaCarga,
      () => {
        this.rt.navigate(['/ficha', this.fichaId]);
      });
  };

  public voltar = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['/ficha', this.fichaId]);
  };
}