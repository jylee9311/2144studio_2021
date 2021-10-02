# Mission

## 미션지
- 미션 종이는 임시로 구한 것
- (0,0,0)에 위치

## 맵
1. 테두리 blur
    - map>map_image_edit.psd
    - 포토샵에 적혀있는대로 실행하여 $png$ 저장
    - 그때 그때 제작하면 됨    
2. 맵 사진
    - 맵 사진은 현재 없음
    - 추후 맵 에디터로 만든 맵 캡쳐하면 될듯
    - shader 추가, 터치입력시 물흐르듯이 흐름  
    [shaderLab Syntax 참고](https://docs.unity3d.com/540/Documentation/Manual/SL-Shader.html)
3. WaterTexture
    - 평소: Magnitude 0.05로 흐름
    - 클릭시: 서서히 증가하였다가 줄어듦 (7s)
    - Water2DScript의 Speed로 유속 조절 가능
4. 맵 진입
    - Map(버튼) 클릭 시 씬 이동

## Mission
> Mission 내용은 Mission.csv에 포함되어있으며,  
> CSVReader.cs에 의해 파싱되어 저장됨
### 1. Rank
1. font (Gotischelnitialen.ttf)
    - mission > font
    - TextMeshPro 이용 [참고](https://lioicreim.tistory.com/222)
