
cc.Class({
    extends: cc.Component,

    properties: {

    },


    start () {

    this._timer=0.0;
    },

     update (dt) {
     
     this._timer +=dt;

     if(this._timer >=0.1){

     //this.node.destroy();
     this.node.parent.destroy();

     }


     
     
     },
});
