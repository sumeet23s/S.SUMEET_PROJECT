
const {ccclass, property} = cc._decorator;

@ccclass
export default class NewClass extends cc.Component {

    @property(cc.Prefab)
    
    bullet cc.Prefab = null;

    @property(cc.Sprite )
    Bar cc.Sprite = null;

    @property
    shoot =false;

     spawn(event)
     {

          if(this.shoot){
          var newBullet = cc.instantiate(this.bullet);
          newBullet.setPosition(this.node.getChildByName('player').position.x ,this.node.getChildByName('player').position.y +30);
          this.node.addChild(newBullet);
          this.shoot = false;
          this.Bar.fillRange =0;
          }
          }

     onLoad () {

     this.node.on('mousedown', this.spawn,this);

     }


    start () {
     this.progress = 0;
  
    }

     update (dt) {
     
     if(this.shoot == false){
    
    
     this.Bar.fillRange += 0.4 *dt;
     
     if(this.Bar.fillRange == 1){

     this.shoot = true;
     
     }

     }

     }
}
