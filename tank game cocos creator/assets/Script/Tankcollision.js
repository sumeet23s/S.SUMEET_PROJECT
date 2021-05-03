

cc.Class({
    extends: cc.Component,

    properties: {
        cannon: {
            default: null,
            type: cc.Node
        },

              score: {
            default: null,
            type: cc.Node
        },



        hit:number =0,
    },

    

     onLoad () {
     
     var manager = cc.director.getCollisionManager();
     manager.enabled = true;
     manager.enabledDrawBoundingBox = true;
 
     
     },

     onCollisionEnter :function (other, self) {
    
    
    if(this.cannon.active == false){
   
   this.hit++;

    if(this.hit == 2){

    this.score.getComponent('score').score +=2;
    this.node.destroy();
 
    }
    }
 
    },

    
   update (dt) {},
});
