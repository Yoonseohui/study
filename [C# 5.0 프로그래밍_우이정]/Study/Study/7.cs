﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Class7
    {
        public static void Main(string[] args)
        {
            // 1 번
            // 클래스 : 객체를 정의해 놓은 것, 객체를 생성하기 위한 설계도
            // 객체 : 클래스에 정의된 내용이 메모리에 생성된 것, (클래스로부터 객체를 생성하는 과정을 클래스의 인스턴스화라고 함)
            // 인스턴스 : 어떤 클래스로부터 만들어진 객체를 해당 클래스의 인스턴스라고 함


            // 2 번
            //class A
            //{
            //}

            //class B
            //{
            //}

            //class C
            //{
            //    public static void Main()
            //    {
            //        A a = new A();
            //        B b = new B();
            //        A c = new B();    -> 선언된 클래스명과 생성자의 클래스 명이 서로 다름
            //        B d = new A();    -> 선언된 클래스명과 생성자의 클래스 명이 서로 다름
            //    }
            //}


            // 3 번
            // this 키워드 : 현재 인스턴스를 참조함. non-static 메소드에서만 사용가능 (정적 메소드에서는 현재 인스턴스가 없음)
            // base 키워드 : 상속된 메소드(부모) 호출 가능. 베이스 타입에서 지정된 메소드를 호출. non-static 메소드에서만 사용가능. 


            // 4 번 - 2
            // 1. struct 키워드를 이용하여 선언한다.
            // 2. 복사할 때 얕은 복사가 이루어진다.
            // 3. 참조 형식이다.                      => 값 형식임
            // 4. 메소드를 가질 수 있다.


            // 5 번
            // 다형성 : 객체가 여러 형태를 가질 수 있는 것. 자신으로부터 상속받아 만들어진 자식 클래스(파생 클래스)를 통해 다형성을 실현함
            // 오버라이딩과의 관계 : 오버라이딩으로 통해 다형성을 실현할 수 있음. 객체를 재정의할 수 있음.
        }
    }
}
