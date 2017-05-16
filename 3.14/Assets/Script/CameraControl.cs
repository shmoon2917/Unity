using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Vector3 vec;
	public Vector3 vec2;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (vec);
		gameObject.transform.Translate (vec2);
	}
}


// 변수 : 데이터가 들어가는 상자(값을 저장할 수 있고, 필요할 때는 그 값을 참조할 수 있다.) 
// 특징 1) 변수를 사용하려면 먼저 타입을 선언해야 한다. ex) int a = 100;
// 특징 2) 데이터 타입으로는 정수형, 실수형, 문자(열), 논리, 객체 형식이 있다.

// 조건문 : 프로그래밍에서 프로그램 흐름을 조건에 따라 실행시키게끔 하는 문장.
// 종류 : if~else문(if, else if, else) , switch
//
// 1) if~else문
//
//  if(조건식){
//		참일 경우에 실행될 문장.
//  } else if(조건식){
//		참일 경우에 실행될 문장.
//  } else {
//		위의 조건식에 아무것도 해당하지 않을 때 실행될 문장
//  }
//
// 2) switch 문
//
//  String day = "수";
//
//  switch (day)
//  {
//		case "일":
//			Console.WriteLine("일요일");
//			break;
//		case "월":
//			Console.WriteLine("월요일");
//			break;
//		case "화":
//			Console.WriteLine("화요일");
//			break;
//		case "수":
//			Console.WriteLine("수요일");
//			break;
//		case "목":
//			Console.WriteLine("목요일");
//			break;
//		case "금":
//			Console.WriteLine("금요일");
//			break;
//		case "토":
//			Console.WriteLine("토요일");
//			break;
//		default:
//			Console.WriteLine("아무 요일에도 해당하지 않습니다.");
//			break;
//	}
// 
//
// 반복문 : 특정 조건을 만족할때 까지 계속 반복하여 실행하는 문장
// 종류 : while(참일 때 동안 반복~), do~while(한번은 먼저 실행 후 반복~), for(참이 될 때까지 반복~), foreach(순회하며 차례대로 접근~)
// 
// 1) while (조건식) {
// 		반복 실행될 코드
//	  }
//
// 2) do {
// 		반복 실행될 코드
//    } while (조건식); // 여기서 주의할 것은 마지막에 세미콜론이 붙는다는 것.
//
// 3) for(초기식; 조건식; 증감식) {
// 		반복 실행될 코드
//    }
//
// 4) foreach (변수 in 배열 혹은 컬렉션) {
// 		실행될 코드
//	  }
//
// 특징 : 반복문은 중첩 사용 가능하다!
//
// ex)
// 		for (int a = 2; a < 10; a++)
// 		{
//			for (int b = 1; b < 10; b++)
//			{
//				Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
//			}
// 		}
//
//
//
// 함수(메소드) : 일련의 문을 포함하는 코드 블록. 프로그램을 통해 메소드를 호출하고 필요한 메소드 인수를 지정하여 문을 실행
//
// [접근 지정자] 반환형식 메소드명(매개변수_리스트) {
// 		실행될 코드
// }
//
// 클래스 : 다른 형식의 변수, 메소드 및 이벤트를 그룹화하여 사용자 지정 형식을 만들 수 있는 구문. 클래스는 쿠키틀과 같다. 모양과 크기 등을 같게 또는 달리 해서 찍어낼 수 있다. 찍어낸 쿠키는 인스턴스라고 부른다.
//
//	public class Person
//	{
//		// field(클래스가 가지는 변수)
//		public string name;
//
//		// 매개 변수가 없는 생성자(인스턴스를 생성할 때 호출됨)
//		public Person()
//		{
//			name = "unknown";
//		}
//
//		// 매개 변수가 있는 생성자(인스턴스를 생성할 때 변수를 넣고 호출됨)
//		public Person(string nm)
//		{
//			name = nm;
//		}
//
//		// 메소드
//		public void SetName(string newName)
//		{
//			name = newName;
//		}
//}
//	class TestPerson
//	{
//		static void Main()
//		{
//			// 변수가 없는 생성자의 호출(인스턴스 생성1)
//			Person person1 = new Person();
//			Console.WriteLine(person1.name);

//			// 생성된 person1 이라는 인스턴스가 가지는 Setname 함수 호출
//			person1.SetName("John Smith");
//			Console.WriteLine(person1.name);
//
//			// 변수를 하나 가진 생성자의 호출(인스턴스 생성2)
//			Person person2 = new Person("Sarah Jones");
//			Console.WriteLine(person2.name);
//
//		}
//	}