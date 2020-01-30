import { Component, OnInit } from '@angular/core';

const WIDTH_OF_SMALL_SCREEN = 720;

@Component({
  selector: 'app-sidenav',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent implements OnInit {

  private mediaMatcher: MediaQueryList = matchMedia(`(max-width: ${WIDTH_OF_SMALL_SCREEN}px)`);
  constructor() { }

  ngOnInit() {
  }
  showFiller = false;

  isSmallScreen(): boolean {
    // 'True' will be retured if the screen is found to be less than 720px
    return this.mediaMatcher.matches;
  }

}
