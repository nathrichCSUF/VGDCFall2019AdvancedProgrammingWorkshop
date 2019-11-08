//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class FSMPsuedoExample
//{
//    /*
//     * 
//     * THIS IS THE BAD CODE
//     * DONT DO THIS
//     * 
//    bool moving = false;
//    bool attacking = false;
//    bool jumping = false;
//    bool crouching = false;
//    bool dodging = false;
//    int jump_timer = 30;

//    //moving
//    if(!jumping && pressed_move_button() && !attacking){
//        move();
//    }
//    //jump
//    if(pressed_jump_button() && !attacking && !crouching && !dodging){
//        jump();
//    }
//    //attacking
//    if(!jumping && pressed_attack_button()){
//        attack_with_gun();
//    }
//    */
////Rules for FSM
////Defined states: Idle, Move, Jump, Crouch, Dodge, Slide, Ranged_Attack, Melee_Attack
////Idle -> Move, Jump, Crouch, Dodge, Slide, Ranged_Attack, Melee_Attack
////Move -> Idle, Jump, Crouch, Dodge, Slide, Ranged_Attack, Melee_Attack
////Jump -> Idle, Move, Crouch
////Crouch -> Idle, Move, Dodge, Slide
////Dodge -> Idle(when finished)
////Slide -> Idle, Crouch(when finished)
//    enum State
//    {
//        idle,
//        move,
//        crouch,
//        jump,
//        slide,
//        dodge,
//        melee_attack,
//        ranged_attack
//    }
//    State _state = State.idle;

//    //transitional
//    if(_state == State.idle){
//        if(pressed_move_button()){
//            _state = States.move;
//        }
//        if(pressed_jump_button()){
//            _state = States.jump;
//        }
//        //...
//    }
//    if(_state == State.move){

//    }
//    if(_state == State.crouch){

//    }
//    if(_state == State.slide){

//    }
//    if(_state == State.jump){
//        if(on_ground()){
//            if(pressed_move_button()){
//                _state = States.move;
//            }
//            else {
//                _state = States.idle;
//            }
//        }
//    }
//    if(_state == State.dodge){

//    }
//    if(_state == State.melee_attack){

//    }
//    if(_state == State.ranged_attack){

//    }


//    //active
//    if(_state == State.idle){

//    }
//    if(_state == State.move){
//        move();
//    }
//    if(_state == State.crouch){
        
//    }
//    if(_state == State.slide){
//        slide();
//    }
//    if(_state == State.jump){
//        jumpmove();
//    }
//    if(_state == State.dodge){
//        dodge();
//    }
//    if(_state == State.melee_attack){
//        attack_with_melee();
//    }
//    if(_state == State.ranged_attack){
//        attack_with_ranged();
//    }
//} 
