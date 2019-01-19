import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';
import { FichaService } from 'src/app/ficha.service';
import { Route } from '@angular/compiler/src/core';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.css']
})
export class Ficha_Editar implements OnInit {

  private fichaId: number;
  public ficha: any;

  constructor(private route: ActivatedRoute, private fichaService: FichaService, private rt: Router) { 
    this.route.params.subscribe(params => {
      if (params.id) {
        this.fichaId = params.id;
        this.fichaService.getFicha(params.id).subscribe((data: any) => {
          this.ficha = data;
          console.log(data);
        });
      }
    });

  }

  ngOnInit() {
  }

  public AlterarCarga = function(event:Event, fichaId: number, exercicioSerieId: number, nomeExercicio: string, carga: number) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['alterarCarga', {fichaId: fichaId, clienteId: this.ficha.clienteId, exercicioSerieId: exercicioSerieId, nomeExercicio: nomeExercicio, valorCarga: carga}])
  };

  public adicionarSerie = function(event:Event) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['/serieFicha', this.fichaId]);
  };

  public adicionarExercicio = function(event: Event, serieId: number) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['/exercicioSerie', {fichaId: this.fichaId, serieFichaId: serieId}]);
  };

}
