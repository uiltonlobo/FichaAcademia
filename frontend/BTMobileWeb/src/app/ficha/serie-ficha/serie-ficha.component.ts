import { ActivatedRoute, Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { FichaService } from 'src/app/ficha.service';

@Component({
  selector: 'app-serie-ficha',
  templateUrl: './serie-ficha.component.html',
  styleUrls: ['./serie-ficha.component.css']
})
export class Ficha_SerieFicha implements OnInit {
  
  public fichaId: number;
  public rotuloSerie: any = "";

  constructor(private activatedRoute: ActivatedRoute, private fichaService: FichaService, private rt: Router) { 
    this.activatedRoute.params.subscribe(params => {
      if (params.fichaId) this.fichaId = params.fichaId;
    });
  }

  ngOnInit() {
  }

  public adicionarSerie = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.fichaService.adicionarSerieFicha(this.fichaId, this.rotuloSerie,
      () => { this.rt.navigate(['/ficha', this.fichaId]); });
  };

  public voltar = function(event: Event) {
    event.preventDefault();
    event.stopPropagation();

    this.rt.navigate(['/ficha', this.fichaId]);
  };
}
