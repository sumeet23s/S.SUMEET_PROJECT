
cc.Class({
    extends: cc.Component,

    properties: {

    Player :{

    default:null,
    type: cc.Node,
    },

    button : cc.Button
    },


    onLoad : function() {

    this.button.node.on;
    this.left = false;
    this.right = false;
    },


    start : function(){
    this._timer = 0.0;
    

    },

  update : function(dt){

  if(this.button.node.on && this.node.x >=-444){ 
   this.Player.position.x -= 100*dt;
   }

   if(this.button.node.off &&  this.node.x >=-444){
 this.Player.position.x -= 100*dt;
  }
  },

});
