# Thedume
---

## 📌1.프로젝트 소개

![Untitled 3](https://user-images.githubusercontent.com/76659528/109339057-69d0d800-78aa-11eb-9a8f-bc3a48f14046.png)

세계에는 수천만개의 소프트웨어가 존재합니다.

TheDume에서는 각종 소프트웨어를 한번에 관리 할 수 있도록 도와드립니다.

사용자는 분야별로 정리된 소프트웨어 목록에서 필요한 소프트웨어를 라이브러리에 담고,

설치하며, 실행 할 수 있습니다! 

귀찮게 여러 사이트를 돌면서 소프트웨어를 다운받지 않아도 됩니다!

---

## 📕2.개발자 소개

김성진

소프트웨어 공학과 2학년 재학 중

이메일 : asdf74591@gmail.com

깃허브 : [https://github.com/Thedum2](https://github.com/Thedum2)

백준 : coco74591

 

---

![image](https://user-images.githubusercontent.com/76659528/109339246-b3212780-78aa-11eb-9d91-522e96a1408f.png)

---

## 📕4.프로그램 실행을 위한 가이드

#프로그램 실행을 위한 환경
1. .net framework 4 이상의 버전
2. 인터넷 연결

#DATABASE의 스키마 구조
1.Table (Program_info)


![image](https://user-images.githubusercontent.com/76659528/110469039-75c76000-811c-11eb-8cfd-4901ff6b954f.png)


name_eng - 프로그램의 영문이름입니다

name_kor - 프로그램의 한글이름입니다

image_link - 프로그램의 대표 이미지 링크입니다

runwindow - 프로그램의 실행화면 이미지 링크입니다

download_link - 프로그램의 다운로드 링크입니다

homepage_link - 프로그램의 개발사 대표 홈페이지 링크입니다

download_count - 프로그램이 다운로드 받은 횟수입니다

verification - 인증 구분 태그입니다 1이면 노출,0이면 미노출입니다

program_tag1 - 프로그램의 대분류입니다

program_tag2 - 프로그램의 소분류입니다

pro_info - 프로그램의 간단한 설명입니다


2.Table (user_account)


 id - 유저의 아아디입니다
	
 password - 유저의 비밀번호입니다
 
 nickname - 유저의 닉네임입니다
 
 email - 유저의 이메일입니다
 
 librarypro1~50 - 유저가 라이브러리에 추가한 프로그램들입니다
 
 lanpro1~15 - 유저가 런쳐에 추가한 프로그램 목록들입니다
---

