
cc.Class({
    extends: cc.Component,

    properties: {

    speed : number = 300,


    },

    
     onLoad : function(){

     var manager = cc.director.getCollisionManager();
     manager.enabled = true;
     manager.enabledDrawBoundingBox = true;
      
     },



    onCollisionEnter : function  (other, self) {

   
    
    this.node.getChildByName("EnemyBullet").active = false;
    this.node.getChildByName("Hiteffect").active = true;

    this.speed = 0;

   

    },
    start () {

    },

     update (dt) {
     
     this.node.y -= this.speed* dt;
     
     
     },
});
