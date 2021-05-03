
cc.Class({
    extends: cc.Component,

    properties: {
      
    lifeline :[cc.Node],
 
    hit: number =0,


    },


   onCollisionEnter :function (other, self) {
  this.hit++;

  this.lifeline[this.hit -1].active = false;
 
  if(this.hit == 3){
 // console.log("the state of gameover" +this.node.getChildByName("Gameover").active);

  this.node.getChildByName("Gameover").active = true;

 // console.log("the state of gameover" +this.node.getChildByName("Gameover").active);

  }

    },

});
