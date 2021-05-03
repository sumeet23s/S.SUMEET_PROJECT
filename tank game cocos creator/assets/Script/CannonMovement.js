// Learn cc.Class:
//  - https://docs.cocos.com/creator/manual/en/scripting/class.html
// Learn Attribute:
//  - https://docs.cocos.com/creator/manual/en/scripting/reference/attributes.html
// Learn life-cycle callbacks:
//  - https://docs.cocos.com/creator/manual/en/scripting/life-cycle-callbacks.html

cc.Class({
    extends: cc.Component,

    properties: {
      

    speed : 0,
    },

   

   onLoad () {},

    start () {
    this._timer = 0.0;
    },

   update (dt) {
   this._timer += dt;


       if ( this._timer >= 2.0 && this._timer <= 9.0) {
this.node.x -=this.speed*dt;
    }

       if ( this._timer >=9.0 && this._timer<=24.0) {
this.node.x +=this.speed*dt;
    }

    if (  this._timer>=24.0) {
this.node.y -=this.speed*dt;
    }

   
   },

});
